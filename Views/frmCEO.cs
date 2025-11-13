using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FakeMadrid.Models;

namespace FakeMadrid.Views
{
    public partial class frmCEO : Form
    {
        private CEO[] _CEOs = new CEO[5];

        public CEO[] CEOs
        {
            get { return _CEOs; }
            set { _CEOs = value; }
        }
        public frmCEO()
        {
            InitializeComponent();

            // Gắn sự kiện
            lblExit.MouseEnter += lblExit_MouseEnter;
            lblExit.MouseLeave += lblExit_MouseLeave;

            #region CEO 
            CEOs[0] = new CEO("Nguyen Hoang Long", new PictureBox(), "29-10-2006", "TP.Ben Tre, Ben Tre");
            CEOs[0].Image.Image = global::FakeMadrid.Properties.Resources.Long;

            CEOs[1] = new CEO("Tran Nguyen Xuan Son", new PictureBox(), "17-12-2006", "Binh Dinh");
            CEOs[1].Image.Image = global::FakeMadrid.Properties.Resources.CEOSon;

            CEOs[2] = new CEO("Dong Quoc Thai", new PictureBox(), "31-8-2006", "Binh Chanh, Tp.Ho Chi Minh");
            CEOs[2].Image.Image = global::FakeMadrid.Properties.Resources.CEOThai;

            CEOs[3] = new CEO("Dang Nhat Tinh", new PictureBox(), "26-6-2006", "Kien Giang");
            CEOs[3].Image.Image = global::FakeMadrid.Properties.Resources.CEOTinh;

            CEOs[4] = new CEO("Kha Thai Bao", new PictureBox(), "01-05-2006", "Can Tho");
            CEOs[4].Image.Image = global::FakeMadrid.Properties.Resources.Bao;
            #endregion
        }

        private void frmCEO_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red; // Màu khi rê chuột vào
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Black; // Màu khi rời chuột (mặc định)
        }

        #region xu ly su kien click
        private void imgTinh_Click(object sender, EventArgs e)
        {
            frmCEOInfor f = new frmCEOInfor(CEOs[3]);
            f.ShowDialog();
        }

        private void imgLong_Click(object sender, EventArgs e)
        {
            frmCEOInfor f = new frmCEOInfor(CEOs[0]);
            f.ShowDialog();
        }

        private void imgSon_Click(object sender, EventArgs e)
        {
            frmCEOInfor f = new frmCEOInfor(CEOs[1]);
            f.ShowDialog();
        }

        private void imgThai_Click(object sender, EventArgs e)
        {
            frmCEOInfor f = new frmCEOInfor(CEOs[2]);
            f.ShowDialog();
        }

        private void imgBao_Click(object sender, EventArgs e)
        {
            frmCEOInfor f = new frmCEOInfor(CEOs[4]);
            f.ShowDialog();
        }


        #endregion

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
