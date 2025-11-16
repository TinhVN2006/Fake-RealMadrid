namespace FakeMadrid
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.crtTranDau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtPhanTramTienThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtDoanhThuTheoNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtTranDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtPhanTramTienThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtDoanhThuTheoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.crtPhanTramTienThu);
            this.flowLayoutPanel1.Controls.Add(this.crtTranDau);
            this.flowLayoutPanel1.Controls.Add(this.crtDoanhThuTheoNam);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1878, 1044);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTongDoanhThu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1863, 70);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1104, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "1,6 %";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(531, 22);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(525, 37);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 1.098.830.990 €\r\n";
            // 
            // crtTranDau
            // 
            chartArea5.Name = "ChartArea1";
            this.crtTranDau.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.crtTranDau.Legends.Add(legend5);
            this.crtTranDau.Location = new System.Drawing.Point(880, 79);
            this.crtTranDau.Name = "crtTranDau";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series5.Legend = "Legend1";
            series5.Name = "Trận đấu";
            this.crtTranDau.Series.Add(series5);
            this.crtTranDau.Size = new System.Drawing.Size(992, 319);
            this.crtTranDau.TabIndex = 0;
            this.crtTranDau.Text = "chart1";
            this.crtTranDau.Click += new System.EventHandler(this.crtTranDau_Click);
            // 
            // crtPhanTramTienThu
            // 
            chartArea4.Name = "ChartArea1";
            this.crtPhanTramTienThu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.crtPhanTramTienThu.Legends.Add(legend4);
            this.crtPhanTramTienThu.Location = new System.Drawing.Point(3, 79);
            this.crtPhanTramTienThu.Name = "crtPhanTramTienThu";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.crtPhanTramTienThu.Series.Add(series4);
            this.crtPhanTramTienThu.Size = new System.Drawing.Size(871, 319);
            this.crtPhanTramTienThu.TabIndex = 0;
            this.crtPhanTramTienThu.Text = "chart2";
            // 
            // crtDoanhThuTheoNam
            // 
            chartArea6.Name = "ChartArea1";
            this.crtDoanhThuTheoNam.ChartAreas.Add(chartArea6);
            this.crtDoanhThuTheoNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend6.Name = "Legend1";
            this.crtDoanhThuTheoNam.Legends.Add(legend6);
            this.crtDoanhThuTheoNam.Location = new System.Drawing.Point(3, 404);
            this.crtDoanhThuTheoNam.Name = "crtDoanhThuTheoNam";
            this.crtDoanhThuTheoNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Euro";
            this.crtDoanhThuTheoNam.Series.Add(series6);
            this.crtDoanhThuTheoNam.Size = new System.Drawing.Size(1863, 628);
            this.crtDoanhThuTheoNam.TabIndex = 0;
            this.crtDoanhThuTheoNam.Text = "chart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1878, 1044);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtTranDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtPhanTramTienThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtDoanhThuTheoNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTranDau;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtPhanTramTienThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtDoanhThuTheoNam;
    }
}