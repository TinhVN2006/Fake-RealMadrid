using FakeMadrid.Models;
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
    public partial class frmCEOInfor : Form
    {

        private CEO _CEOcurrent;

        public CEO CEOcurrent
        {
            get => _CEOcurrent;
            set => _CEOcurrent = value;
        }
        public frmCEOInfor(CEO selectedCEO)
        {
            InitializeComponent();
            CEOcurrent = selectedCEO;

            // Gắn sự kiện
            lblExit.MouseEnter += lblExit_MouseEnter;
            lblExit.MouseLeave += lblExit_MouseLeave;
        }

        private void frmCEOInfor_Load(object sender, EventArgs e)
        {
            imgCEO.Image = CEOcurrent.Image.Image;
            lblText.Text = CEOcurrent.Name + "\r\nborn on " + CEOcurrent.Birth + ", in " + CEOcurrent.Hometown + " Vietnam.\r\nCEO of Fake Madrid Club.\r\n\r\nWith Four Close Friends, he founded the club\r\nKnown for his vision, dedication, and teamwork.\r\n" + CEOcurrent.Name + " continues to guide the club\r\nToward excellence and inspire to greatness on and off the field.\r\n" + "-HCMUE-";
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red; // Màu khi rê chuột vào
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Black; // Màu khi rời chuột (mặc định)
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
