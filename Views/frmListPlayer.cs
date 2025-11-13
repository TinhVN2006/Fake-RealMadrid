using FakeMadrid.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmListPlayer : Form
    {
        public frmListPlayer()
        {
            InitializeComponent();
        }

        private void frmListPlayer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            dgvPlayer.DataSource = db.Players.OrderBy(p => p.player_id);
            
        }
        #region Nút chức năng

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra ID
            if (string.IsNullOrWhiteSpace(txtPlayerId.Text))
            {
                MessageBox.Show("Bạn phải nhập ID cầu thủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlayerId.Focus();
                return;
            }

            if (!int.TryParse(txtPlayerId.Text, out int playerId))
            {
                MessageBox.Show("ID cầu thủ phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlayerId.Focus();
                return;
            }

            // 2. Lấy dữ liệu từ form
            string playerName = txtPlayerName.Text;
            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Bạn phải nhập tên cầu thủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlayerName.Focus();
                return;
            }

            if (!int.TryParse(txtSoAo.Text, out int jerseyNumber))
            {
                MessageBox.Show("Số áo phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoAo.Focus();
                return;
            }

            string position = cbbViTri.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Bạn phải chọn vị trí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbViTri.Focus();
                return;
            }

            DateTime dateOfBirth = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string nationality = txtQuocTich.Text;

            if (!decimal.TryParse(txtChieuCao.Text, out decimal height))
            {
                MessageBox.Show("Chiều cao phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChieuCao.Focus();
                return;
            }

            if (!decimal.TryParse(txtCanNang.Text, out decimal weight))
            {
                MessageBox.Show("Cân nặng phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCanNang.Focus();
                return;
            }

            string preferredFoot = cbbChanThuan.SelectedItem?.ToString();
            DateTime joinDate = dtpNgayGiaNhap.Value;
            DateTime contractEndDate = dtpNgayHetHan.Value;

            if (!decimal.TryParse(txtGia.Text, out decimal marketValue))
            {
                MessageBox.Show("Giá trị thị trường phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGia.Focus();
                return;
            }

            if (!decimal.TryParse(txtLuong.Text, out decimal salary))
            {
                MessageBox.Show("Lương phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }

            string previousClub = txtCLBTruoc.Text;
            string status = cbbTrangThai.SelectedItem?.ToString();

            // 3. Kết nối DB
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // 4. Kiểm tra trùng ID
            Player player = db.Players.Where(p => p.player_id == playerId).SingleOrDefault();
            if (player != null)
            {
                MessageBox.Show("Mã cầu thủ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlayerId.Focus();
                return;
            }

            // 5. Tạo mới Player và gán dữ liệu
            player = new Player();
            player.player_id = playerId;
            player.player_name = playerName;
            player.jersey_number = jerseyNumber;
            player.position = position;
            player.date_of_birth = dateOfBirth;
            player.email = email;
            player.phone = phone;
            player.nationality = nationality;
            player.height = height;
            player.weight = weight;
            player.preferred_foot = preferredFoot;
            player.join_date = joinDate;
            player.contract_end_date = contractEndDate;
            player.market_value = marketValue;
            player.salary = salary;
            player.previous_club = previousClub;
            player.status = status;

            // 6. Thêm và lưu DB
            db.Players.InsertOnSubmit(player);
            db.SubmitChanges();

            // 7. Load lại dữ liệu và thông báo
            loadData();
            MessageBox.Show("Thêm mới cầu thủ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu input từ form
            int playerId = int.Parse(txtPlayerId.Text); // IDENTITY, dùng để tìm bản ghi
            string playerName = txtPlayerName.Text;
            int jerseyNumber = int.Parse(txtSoAo.Text);
            string position = cbbViTri.SelectedItem.ToString();
            DateTime dateOfBirth = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string nationality = txtQuocTich.Text;
            decimal height = decimal.Parse(txtChieuCao.Text);
            decimal weight = decimal.Parse(txtCanNang.Text);
            string preferredFoot = cbbChanThuan.SelectedItem.ToString();
            DateTime joinDate = dtpNgayGiaNhap.Value;
            DateTime contractEndDate = dtpNgayHetHan.Value;
            decimal marketValue = decimal.Parse(txtGia.Text);
            decimal salary = decimal.Parse(txtLuong.Text);
            string previousClub = txtCLBTruoc.Text;
            string status = cbbTrangThai.SelectedItem.ToString();

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            // Tìm cầu thủ theo player_id
            Player player = db.Players.Where(p => p.player_id == playerId).SingleOrDefault();
            if (player == null)
            {
                MessageBox.Show("Mã cầu thủ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlayerId.Focus();
                return;
            }
            else
            {

                // Cập nhật thông tin
                player.player_name = playerName;
                player.jersey_number = jerseyNumber;
                player.position = position;
                player.date_of_birth = dateOfBirth;
                player.email = email;
                player.phone = phone;
                player.nationality = nationality;
                player.height = height;
                player.weight = weight;
                player.preferred_foot = preferredFoot;
                player.join_date = joinDate;
                player.contract_end_date = contractEndDate;
                player.market_value = marketValue;
                player.salary = salary;
                player.previous_club = previousClub;
                player.status = status;

                db.SubmitChanges(); // lưu vào DB

                loadData(); // load lại DataGridView
                MessageBox.Show("Cập nhật cầu thủ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string timKiem = txtSearch.Text;
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();

            if (string.IsNullOrEmpty(timKiem))
            {
                loadData();
            }
            else
            {
                dgvPlayer.DataSource = db.Players
                    .Where(p => p.player_name.Contains(timKiem) || p.player_id.ToString().Contains(timKiem))
                    .ToList();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //frmPlayerPrinter frm = new frmPlayerPrinter(); // tạo form in danh sách cầu thủ
            //frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int playerId = int.Parse(txtPlayerId.Text);

            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            Player player = db.Players.Where(p => p.player_id == playerId).SingleOrDefault();

            if (player == null)
            {
                MessageBox.Show("Mã cầu thủ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlayerId.Focus();
                return;
            }
            else
            {
                var attendance = db.PlayerAttendances.Where(a => a.player_id == playerId).ToList();
                db.PlayerAttendances.DeleteAllOnSubmit(attendance);

                var stats = db.PlayerMatchStatistics.Where(s => s.player_id == playerId).ToList();
                db.PlayerMatchStatistics.DeleteAllOnSubmit(stats);

                var injuries = db.Injuries.Where(i => i.player_id == playerId).ToList();
                db.Injuries.DeleteAllOnSubmit(injuries);

                var medicals = db.MedicalRecords.Where(m => m.player_id == playerId).ToList();
                db.MedicalRecords.DeleteAllOnSubmit(medicals);

                var seasons = db.SeasonStatistics.Where(s => s.player_id == playerId).ToList();
                db.SeasonStatistics.DeleteAllOnSubmit(seasons);

                var transfers = db.Transfers.Where(t => t.player_id == playerId).ToList();
                db.Transfers.DeleteAllOnSubmit(transfers);

                var contracts = db.Contracts.Where(c => c.player_id == playerId).ToList();
                db.Contracts.DeleteAllOnSubmit(contracts);

                db.SubmitChanges(); // Xóa tất cả dữ liệu liên quan trước

                
                // Sau đó mới xóa Player
                db.Players.DeleteOnSubmit(player);
                db.SubmitChanges();


                loadData(); // load lại DataGridView
                MessageBox.Show("Xóa cầu thủ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Truyền dữ liệu từ db
        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Xác định cái Row đang chọn
            int idrow = e.RowIndex;
            if (idrow == -1) return; //header
            hienThiDuLieuDong(idrow);
        }

        private void hienThiDuLieuDong(int idrow)
        {
            DataClassesQuanLyDoiBongDataContext db = new DataClassesQuanLyDoiBongDataContext();
            int id = int.Parse(dgvPlayer.Rows[idrow].Cells[0].Value.ToString());
            //Hiển thị dữ liệu
            Player player = db.Players.Where(p => p.player_id == id).SingleOrDefault();
            if(player != null)
            {
                txtPlayerId.Text = player.player_id.ToString();
                txtPlayerName.Text = player.player_name;
                txtSoAo.Text = player.jersey_number.ToString();
                cbbViTri.SelectedItem = player.position;
                dtpNgaySinh.Value = player.date_of_birth.Value;
                txtEmail.Text = player.email;
                txtPhoneNumber.Text = player.phone;
                txtQuocTich.Text = player.nationality;
                txtChieuCao.Text = player.height.ToString();
                txtCanNang.Text = player.weight.ToString();
                cbbChanThuan.SelectedItem = player.preferred_foot;
                dtpNgayGiaNhap.Value = player.join_date.Value;
                dtpNgayHetHan.Value = player.contract_end_date.Value;
                txtGia.Text = player.market_value.ToString();
                txtLuong.Text = player.salary.ToString();
                txtCLBTruoc.Text = player.previous_club;
                cbbTrangThai.SelectedItem = player.status;


            }
        }
        #endregion

    }
}