using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmLogin : Form
    {
        private int _iCount;
        public int iCount
        {
            get { return _iCount; }
            set { _iCount = value; }
        }

        private bool _locked;
        public bool locked
        {
            get { return _locked; }
            set { _locked = value; }
        }
        public frmLogin()
        {
            InitializeComponent();
            iCount = 0;
            locked = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // 🔹 Ban đầu tắt nút xác nhận
            btnLogin.Enabled = false;

            #region Gắn sự kiện theo dõi khi nhập tên
            txtUser.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                if (coTen && coPass) btnLogin.Enabled = true;
                iCount = 0;
            };
            txtPass.TextChanged += (s, args) =>
            {
                if (locked) return;
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                if (coTen && coPass) btnLogin.Enabled = true;
            };
            #endregion
        }


        #region Xu ly hieu ung
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.ForeColor = Color.Black;
        }
        #endregion 

        #region Xu Ly Event Click

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "son" && txtPass.Text == "son")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCEO mainForm = new frmCEO();
                mainForm.Show();
                // Thực hiện các hành động sau khi đăng nhập thành công

                this.Close();
            }
            else
            {
                iCount++;
                if (iCount >= 3)
                {
                    MessageBox.Show("Bạn đã nhập sai quá nhiều lần.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogin.Enabled = false;
                    locked = true;
                    return;
                }
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.Số lần nhập còn lại "+(3 - iCount), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblForgetPass.Visible = true;
            }
            
        }
        #endregion

    }
}
