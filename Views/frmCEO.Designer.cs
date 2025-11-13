namespace FakeMadrid.Views
{
    partial class frmCEO
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
            this.lblExit = new System.Windows.Forms.Label();
            this.imgTinh = new System.Windows.Forms.PictureBox();
            this.imgThai = new System.Windows.Forms.PictureBox();
            this.imgSon = new System.Windows.Forms.PictureBox();
            this.imgLong = new System.Windows.Forms.PictureBox();
            this.imgBao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(1068, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(48, 33);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "❌";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // imgTinh
            // 
            this.imgTinh.Image = global::FakeMadrid.Properties.Resources.CEOTinh;
            this.imgTinh.Location = new System.Drawing.Point(12, 186);
            this.imgTinh.Name = "imgTinh";
            this.imgTinh.Size = new System.Drawing.Size(175, 225);
            this.imgTinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTinh.TabIndex = 4;
            this.imgTinh.TabStop = false;
            this.imgTinh.Click += new System.EventHandler(this.imgTinh_Click);
            // 
            // imgThai
            // 
            this.imgThai.Image = global::FakeMadrid.Properties.Resources.CEOThai;
            this.imgThai.Location = new System.Drawing.Point(689, 186);
            this.imgThai.Name = "imgThai";
            this.imgThai.Size = new System.Drawing.Size(175, 225);
            this.imgThai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgThai.TabIndex = 5;
            this.imgThai.TabStop = false;
            this.imgThai.Click += new System.EventHandler(this.imgThai_Click);
            // 
            // imgSon
            // 
            this.imgSon.Image = global::FakeMadrid.Properties.Resources.CEOSon;
            this.imgSon.Location = new System.Drawing.Point(461, 186);
            this.imgSon.Name = "imgSon";
            this.imgSon.Size = new System.Drawing.Size(175, 225);
            this.imgSon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSon.TabIndex = 6;
            this.imgSon.TabStop = false;
            this.imgSon.Click += new System.EventHandler(this.imgSon_Click);
            // 
            // imgLong
            // 
            this.imgLong.Image = global::FakeMadrid.Properties.Resources.CEOLong;
            this.imgLong.Location = new System.Drawing.Point(234, 186);
            this.imgLong.Name = "imgLong";
            this.imgLong.Size = new System.Drawing.Size(175, 225);
            this.imgLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLong.TabIndex = 7;
            this.imgLong.TabStop = false;
            this.imgLong.Click += new System.EventHandler(this.imgLong_Click);
            // 
            // imgBao
            // 
            this.imgBao.Image = global::FakeMadrid.Properties.Resources.CEOBao;
            this.imgBao.Location = new System.Drawing.Point(924, 186);
            this.imgBao.Name = "imgBao";
            this.imgBao.Size = new System.Drawing.Size(175, 225);
            this.imgBao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBao.TabIndex = 8;
            this.imgBao.TabStop = false;
            this.imgBao.Click += new System.EventHandler(this.imgBao_Click);
            // 
            // frmCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FakeMadrid.Properties.Resources.BackgoundCEO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 633);
            this.Controls.Add(this.imgBao);
            this.Controls.Add(this.imgLong);
            this.Controls.Add(this.imgSon);
            this.Controls.Add(this.imgThai);
            this.Controls.Add(this.imgTinh);
            this.Controls.Add(this.lblExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCEO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCEO";
            this.Load += new System.EventHandler(this.frmCEO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox imgTinh;
        private System.Windows.Forms.PictureBox imgThai;
        private System.Windows.Forms.PictureBox imgSon;
        private System.Windows.Forms.PictureBox imgLong;
        private System.Windows.Forms.PictureBox imgBao;
    }
}