namespace FakeMadrid.Views
{
    partial class frmDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.panelHead = new System.Windows.Forms.Panel();
            this.mStripToolBox = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatchScheduleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageCoachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListCoachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoachContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.imgTrophy = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHead.SuspendLayout();
            this.mStripToolBox.SuspendLayout();
            this.sStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.imgTrophy);
            this.panelHead.Controls.Add(this.imgLogo);
            this.panelHead.Controls.Add(this.mStripToolBox);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1700, 59);
            this.panelHead.TabIndex = 0;
            // 
            // mStripToolBox
            // 
            this.mStripToolBox.AutoSize = false;
            this.mStripToolBox.Dock = System.Windows.Forms.DockStyle.None;
            this.mStripToolBox.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.mStripToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.PlayerManagementToolStripMenuItem,
            this.ManageCoachToolStripMenuItem,
            this.ScheduleToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.mStripToolBox.Location = new System.Drawing.Point(0, 0);
            this.mStripToolBox.Name = "mStripToolBox";
            this.mStripToolBox.Size = new System.Drawing.Size(721, 28);
            this.mStripToolBox.TabIndex = 0;
            this.mStripToolBox.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.toolStripSeparator1,
            this.LogoutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.SystemToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.LogoutToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.ExitToolStripMenuItem.Text = "THOÁT";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitleToolStripMenuItem,
            this.MatchScheduleMenuItem,
            this.ShopToolStripMenuItem,
            this.listCeoToolStripMenuItem});
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.CategoryToolStripMenuItem.Text = "DANH MỤC";
            // 
            // TitleToolStripMenuItem
            // 
            this.TitleToolStripMenuItem.Image = global::FakeMadrid.Properties.Resources._15C1_removebg_preview;
            this.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
            this.TitleToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.TitleToolStripMenuItem.Text = "DANH HIỆU";
            // 
            // MatchScheduleMenuItem
            // 
            this.MatchScheduleMenuItem.Name = "MatchScheduleMenuItem";
            this.MatchScheduleMenuItem.Size = new System.Drawing.Size(223, 24);
            this.MatchScheduleMenuItem.Text = "LỊCH THI ĐẤU";
            // 
            // ShopToolStripMenuItem
            // 
            this.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem";
            this.ShopToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.ShopToolStripMenuItem.Text = "CỬA HÀNG";
            // 
            // listCeoToolStripMenuItem
            // 
            this.listCeoToolStripMenuItem.Name = "listCeoToolStripMenuItem";
            this.listCeoToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.listCeoToolStripMenuItem.Text = "DANH SÁCH CEO";
            this.listCeoToolStripMenuItem.Click += new System.EventHandler(this.listCeoToolStripMenuItem_Click);
            // 
            // PlayerManagementToolStripMenuItem
            // 
            this.PlayerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerListToolStripMenuItem,
            this.PlayerContractToolStripMenuItem});
            this.PlayerManagementToolStripMenuItem.Name = "PlayerManagementToolStripMenuItem";
            this.PlayerManagementToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.PlayerManagementToolStripMenuItem.Text = "QUẢN LÝ CẦU THỦ";
            // 
            // PlayerListToolStripMenuItem
            // 
            this.PlayerListToolStripMenuItem.Name = "PlayerListToolStripMenuItem";
            this.PlayerListToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.PlayerListToolStripMenuItem.Text = "DANH SÁCH CẦU THỦ";
            // 
            // PlayerContractToolStripMenuItem
            // 
            this.PlayerContractToolStripMenuItem.Name = "PlayerContractToolStripMenuItem";
            this.PlayerContractToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.PlayerContractToolStripMenuItem.Text = "HỢP ĐỒNG";
            // 
            // ManageCoachToolStripMenuItem
            // 
            this.ManageCoachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListCoachToolStripMenuItem,
            this.CoachContractToolStripMenuItem});
            this.ManageCoachToolStripMenuItem.Name = "ManageCoachToolStripMenuItem";
            this.ManageCoachToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.ManageCoachToolStripMenuItem.Text = "QUẢN LÝ HLV";
            // 
            // ListCoachToolStripMenuItem
            // 
            this.ListCoachToolStripMenuItem.Name = "ListCoachToolStripMenuItem";
            this.ListCoachToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.ListCoachToolStripMenuItem.Text = "DANH SÁCH HLV";
            // 
            // CoachContractToolStripMenuItem
            // 
            this.CoachContractToolStripMenuItem.Name = "CoachContractToolStripMenuItem";
            this.CoachContractToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.CoachContractToolStripMenuItem.Text = "HỢP ĐỒNG";
            // 
            // ScheduleToolStripMenuItem
            // 
            this.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem";
            this.ScheduleToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ScheduleToolStripMenuItem.Text = "LỊCH";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.HelpToolStripMenuItem.Text = "HỖ TRỢ";
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblInfor});
            this.sStrip.Location = new System.Drawing.Point(0, 808);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(1700, 22);
            this.sStrip.TabIndex = 1;
            this.sStrip.Text = "statusStrip1";
            // 
            // imgTrophy
            // 
            this.imgTrophy.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgTrophy.Image = global::FakeMadrid.Properties.Resources._15C1_removebg_preview;
            this.imgTrophy.Location = new System.Drawing.Point(1576, 0);
            this.imgTrophy.Name = "imgTrophy";
            this.imgTrophy.Size = new System.Drawing.Size(62, 59);
            this.imgTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTrophy.TabIndex = 3;
            this.imgTrophy.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgLogo.Image = global::FakeMadrid.Properties.Resources.Logo;
            this.imgLogo.Location = new System.Drawing.Point(1638, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(62, 59);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Image = global::FakeMadrid.Properties.Resources.iconPasss;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.LoginToolStripMenuItem.Text = "ĐĂNG NHẬP";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "Thời Gian";
            // 
            // lblInfor
            // 
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(119, 17);
            this.lblInfor.Text = "Bạn chưa đăng nhập!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 830);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mStripToolBox;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.panelHead.ResumeLayout(false);
            this.mStripToolBox.ResumeLayout(false);
            this.mStripToolBox.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.MenuStrip mStripToolBox;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatchScheduleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayerContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageCoachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListCoachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CoachContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgTrophy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfor;
        private System.Windows.Forms.Timer timer1;
    }
}