namespace FakeMadrid.Views
{
    partial class frmCEOInfor
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
            this.imgCEO = new System.Windows.Forms.PictureBox();
            this.panelText = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCEO)).BeginInit();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCEO
            // 
            this.imgCEO.Location = new System.Drawing.Point(23, 104);
            this.imgCEO.Name = "imgCEO";
            this.imgCEO.Size = new System.Drawing.Size(150, 200);
            this.imgCEO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCEO.TabIndex = 0;
            this.imgCEO.TabStop = false;
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.Color.White;
            this.panelText.Controls.Add(this.lblText);
            this.panelText.Location = new System.Drawing.Point(209, 104);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(500, 200);
            this.panelText.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 21);
            this.lblText.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(740, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(48, 33);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "❌";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // frmCEOInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FakeMadrid.Properties.Resources.BackgoundCEO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.imgCEO);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCEOInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCEOInfor";
            this.Load += new System.EventHandler(this.frmCEOInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCEO)).EndInit();
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCEO;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblExit;
    }
}