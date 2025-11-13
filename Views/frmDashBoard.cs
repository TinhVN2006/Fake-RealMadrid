using FakeMadrid.Views;
using FakeMadrid.Views;
using System;
using System.Windows.Forms;

namespace FakeMadrid.Views
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }
        string infor = "Bạn chưa đăng nhập!";
        public frmDashBoard(string _infor)
        {
            InitializeComponent();
            infor = _infor;

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblInfor.Text = infor;

            // Mặc định: chưa đăng nhập
            LogoutToolStripMenuItem.Visible = false;
            LoginToolStripMenuItem.Visible = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInfor.Text = "Bạn chưa đăng nhập!";
            LogoutToolStripMenuItem.Visible = false;
            LoginToolStripMenuItem.Visible = true;
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog(); // Dừng lại cho đến khi form login đóng

            if (login.IsLoginSuccess)
            {
                lblInfor.Text = $"Xin chào, {login.LoggedUser}!";
                LogoutToolStripMenuItem.Visible = true;
                LoginToolStripMenuItem.Visible = false;
            }
            else
            {
                lblInfor.Text = "Bạn chưa đăng nhập!";
                LogoutToolStripMenuItem.Visible = false;
                LoginToolStripMenuItem.Visible = true;
            }
        }

        private void listCeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCEO ceo = new frmCEO();
            ceo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void PlayerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPlayer frm = new frmListPlayer();
            frm.Show();
        }
    }
}