using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FakeMadrid
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            this.Load += frmThongKe_Load;
        }

        private bool IsDesignMode()
        {
            // Robust design-mode detection
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                   || (this.Site != null && this.Site.DesignMode)
                   || this.DesignMode;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            if (IsDesignMode()) return; // Prevent runtime-only initializations from running inside the WinForms Designer
            this.WindowState = FormWindowState.Maximized;
            SetupCharts();
            LoadData();
        }

        private void SetupCharts()
        {
            try
            {
                // === CHART 1: SỐ TRẬN ĐẦU (crtTranDau) ===
                if (crtTranDau.ChartAreas.Count == 0) crtTranDau.ChartAreas.Add(new ChartArea("DefaultArea"));
                crtTranDau.Series.Clear();
                crtTranDau.Titles.Clear();
                crtTranDau.Titles.Add("Số trận đầu");
                crtTranDau.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                crtTranDau.Titles[0].ForeColor = Color.FromArgb(255, 209, 0); // Vàng Real Madrid

                var seriesDau = new Series("Số trận đầu")
                {
                    ChartType = SeriesChartType.Bar,
                    Color = Color.FromArgb(0, 70, 173), // Xanh dương RM
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
                seriesDau.ChartArea = crtTranDau.ChartAreas[0].Name;
                crtTranDau.Series.Add(seriesDau);

                // Trục
                crtTranDau.ChartAreas[0].AxisX.Title = "Đội bóng";
                crtTranDau.ChartAreas[0].AxisY.Title = "Số trận";
                crtTranDau.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                crtTranDau.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

                // === CHART 2: PHÂN TRĂM TIỀN THU (crtPhanTramTienThu) ===
                if (crtPhanTramTienThu.ChartAreas.Count == 0) crtPhanTramTienThu.ChartAreas.Add(new ChartArea("PieArea"));
                crtPhanTramTienThu.Series.Clear();
                crtPhanTramTienThu.Titles.Clear();
                crtPhanTramTienThu.Titles.Add("Phân trăm tiền thu");
                crtPhanTramTienThu.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                crtPhanTramTienThu.Titles[0].ForeColor = Color.FromArgb(136, 0, 21); // Đỏ RM

                var seriesPie = new Series("Phân trăm tiền thu")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    Label = "#VALX: #PERCENT{P0}",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
                seriesPie.ChartArea = crtPhanTramTienThu.ChartAreas[0].Name;
                crtPhanTramTienThu.Series.Add(seriesPie);

                // Pie label outside (safe set)
                crtPhanTramTienThu.Series[0]["PieLabelStyle"] = "Outside";

                // === CHART 3: DOANH THU THEO NĂM (crtDoanhThuTheoNam) ===
                if (crtDoanhThuTheoNam.ChartAreas.Count == 0) crtDoanhThuTheoNam.ChartAreas.Add(new ChartArea("ColArea"));
                crtDoanhThuTheoNam.Series.Clear();
                crtDoanhThuTheoNam.Titles.Clear();
                crtDoanhThuTheoNam.Titles.Add("Doanh thu theo năm (€)");
                crtDoanhThuTheoNam.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                crtDoanhThuTheoNam.Titles[0].ForeColor = Color.FromArgb(255, 209, 0);

                var seriesNam = new Series("Euro")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.FromArgb(136, 0, 21),
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
                seriesNam.ChartArea = crtDoanhThuTheoNam.ChartAreas[0].Name;
                crtDoanhThuTheoNam.Series.Add(seriesNam);

                crtDoanhThuTheoNam.ChartAreas[0].AxisX.Title = "Năm";
                crtDoanhThuTheoNam.ChartAreas[0].AxisY.Title = "Doanh thu (€)";
                crtDoanhThuTheoNam.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            }
            catch
            {
                // Swallow exceptions in designer/runtime init to avoid crashing the Designer.
            }
        }

        private void LoadData()
        {
            try
            {
                // Ensure series exist before adding points
                if (crtTranDau.Series.Count == 0 || crtPhanTramTienThu.Series.Count == 0 || crtDoanhThuTheoNam.Series.Count == 0)
                    return;

                // === DỮ LIỆU SỐ TRẬN ĐẦU ===
                var dauData = new[]
                {
                    ("Real Madrid", 38), ("Barcelona", 28), ("Atletico Madrid", 26),
                    ("Sevilla", 18), ("Valencia", 15), ("Villarreal", 18)
                };

                foreach (var item in dauData)
                {
                    var team = item.Item1;
                    var count = item.Item2;
                    crtTranDau.Series["Số trận đầu"].Points.AddXY(team, count);
                }

                // === DỮ LIỆU PHÂN TRĂM TIỀN THU ===
                var thuData = new[]
                {
                    ("Vé xem trận đấu", 40),
                    ("Quảng cáo", 30),
                    ("Bán đồ lưu niệm", 20),
                    ("Các nguồn khác", 10)
                };

                var colors = new[]
                {
                    Color.FromArgb(136, 0, 21),   // Đỏ RM
                    Color.FromArgb(255, 209, 0),  // Vàng RM
                    Color.FromArgb(0, 70, 173),   // Xanh RM
                    Color.Gray
                };

                for (int i = 0; i < thuData.Length; i++)
                {
                    var source = thuData[i].Item1;
                    var percent = thuData[i].Item2;
                    var pointIndex = crtPhanTramTienThu.Series["Phân trăm tiền thu"].Points.AddXY(source, percent);
                    crtPhanTramTienThu.Series["Phân trăm tiền thu"].Points[pointIndex].Color = colors[i];
                }

                // === DỮ LIỆU DOANH THU THEO NĂM ===
                var doanhThuData = new[]
                {
                    (2019, 1000000000L), (2020, 1500000000L), (2021, 2000000000L),
                    (2022, 2500000000L), (2023, 3000000000L)
                };

                foreach (var item in doanhThuData)
                {
                    var year = item.Item1.ToString();
                    var revenue = item.Item2;
                    crtDoanhThuTheoNam.Series["Euro"].Points.AddXY(year, revenue);
                }

                // === TỔNG DOANH THU - CĂN PHẢI ===
                long tong = 1_073_348_290;
                double tangTruong = 1.6;

                // Label tiêu đề
                if (!this.Controls.ContainsKey("lblTitle"))
                {
                    var lblTitle = new Label
                    {
                        Name = "lblTitle",
                        Text = "TỔNG DOANH THU:",
                        Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(136, 0, 21),
                        AutoSize = true,
                        Location = new Point(50, 30)
                    };
                    this.Controls.Add(lblTitle);
                }

                // Label số tiền (căn phải)
                if (!this.Controls.ContainsKey("lblSoTien"))
                {
                    var lblSoTien = new Label
                    {
                        Name = "lblSoTien",
                        Text = $"{tong:N0} €",
                        Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(255, 209, 0),
                        AutoSize = true,
                        Location = new Point(300, 30),
                        TextAlign = ContentAlignment.MiddleRight
                    };
                    this.Controls.Add(lblSoTien);
                }
                else
                {
                    var lbl = (Label)this.Controls["lblSoTien"];
                    lbl.Text = $"{tong:N0} €";
                }

                // Label % tăng trưởng (bên phải số tiền)
                if (!this.Controls.ContainsKey("lblTang"))
                {
                    var lblTang = new Label
                    {
                        Name = "lblTang",
                        Text = $"+{tangTruong}%",
                        Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                        ForeColor = Color.LimeGreen,
                        AutoSize = true,
                        Location = new Point(500, 35)
                    };
                    this.Controls.Add(lblTang);
                }
            }
            catch
            {
                // Avoid crashing the Designer; swallow runtime errors here.
            }
        }

        // Added missing event handler referenced by the Designer.
        // Keeps Designer and runtime stable; show a small info when clicked at runtime.
        private void label2_Click_1(object sender, EventArgs e)
        {
            if (IsDesignMode()) return;
            MessageBox.Show("Tăng trưởng: 1.6%", "Chi tiết tăng trưởng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crtTranDau_Click(object sender, EventArgs e)
        {

        }
    }
}