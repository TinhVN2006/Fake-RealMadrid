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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.panelHead = new System.Windows.Forms.Panel();
            this.imgTrophy = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.mStripToolBox = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.mStripToolBox.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.imgTrophy);
            this.panelHead.Controls.Add(this.imgLogo);
            this.panelHead.Controls.Add(this.mStripToolBox);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(4);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1942, 73);
            this.panelHead.TabIndex = 0;
            // 
            // imgTrophy
            // 
            this.imgTrophy.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgTrophy.Image = global::FakeMadrid.Properties.Resources._15C1_removebg_preview;
            this.imgTrophy.Location = new System.Drawing.Point(1776, 0);
            this.imgTrophy.Margin = new System.Windows.Forms.Padding(4);
            this.imgTrophy.Name = "imgTrophy";
            this.imgTrophy.Size = new System.Drawing.Size(83, 73);
            this.imgTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTrophy.TabIndex = 3;
            this.imgTrophy.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgLogo.Image = global::FakeMadrid.Properties.Resources.Logo;
            this.imgLogo.Location = new System.Drawing.Point(1859, 0);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(83, 73);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // mStripToolBox
            // 
            this.mStripToolBox.AutoSize = false;
            this.mStripToolBox.Dock = System.Windows.Forms.DockStyle.None;
            this.mStripToolBox.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.mStripToolBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStripToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.CategoryToolStripMenuItem,
            this.PlayerManagementToolStripMenuItem,
            this.ManageCoachToolStripMenuItem,
            this.ScheduleToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.mStripToolBox.Location = new System.Drawing.Point(0, 0);
            this.mStripToolBox.Name = "mStripToolBox";
            this.mStripToolBox.Size = new System.Drawing.Size(961, 34);
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
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
            this.SystemToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Image = global::FakeMadrid.Properties.Resources.iconPasss;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.LoginToolStripMenuItem.Text = "ĐĂNG NHẬP";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.LogoutToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
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
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.CategoryToolStripMenuItem.Text = "DANH MỤC";
            // 
            // TitleToolStripMenuItem
            // 
            this.TitleToolStripMenuItem.Image = global::FakeMadrid.Properties.Resources._15C1_removebg_preview;
            this.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
            this.TitleToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.TitleToolStripMenuItem.Text = "DANH HIỆU";
            // 
            // MatchScheduleMenuItem
            // 
            this.MatchScheduleMenuItem.Name = "MatchScheduleMenuItem";
            this.MatchScheduleMenuItem.Size = new System.Drawing.Size(275, 30);
            this.MatchScheduleMenuItem.Text = "LỊCH THI ĐẤU";
            // 
            // ShopToolStripMenuItem
            // 
            this.ShopToolStripMenuItem.Name = "ShopToolStripMenuItem";
            this.ShopToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.ShopToolStripMenuItem.Text = "CỬA HÀNG";
            // 
            // listCeoToolStripMenuItem
            // 
            this.listCeoToolStripMenuItem.Name = "listCeoToolStripMenuItem";
            this.listCeoToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.listCeoToolStripMenuItem.Text = "DANH SÁCH CEO";
            this.listCeoToolStripMenuItem.Click += new System.EventHandler(this.listCeoToolStripMenuItem_Click);
            // 
            // PlayerManagementToolStripMenuItem
            // 
            this.PlayerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerListToolStripMenuItem,
            this.PlayerContractToolStripMenuItem});
            this.PlayerManagementToolStripMenuItem.Name = "PlayerManagementToolStripMenuItem";
            this.PlayerManagementToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.PlayerManagementToolStripMenuItem.Text = "QUẢN LÝ CẦU THỦ";
            // 
            // PlayerListToolStripMenuItem
            // 
            this.PlayerListToolStripMenuItem.Name = "PlayerListToolStripMenuItem";
            this.PlayerListToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.PlayerListToolStripMenuItem.Text = "DANH SÁCH CẦU THỦ";
            this.PlayerListToolStripMenuItem.Click += new System.EventHandler(this.PlayerListToolStripMenuItem_Click);
            // 
            // PlayerContractToolStripMenuItem
            // 
            this.PlayerContractToolStripMenuItem.Name = "PlayerContractToolStripMenuItem";
            this.PlayerContractToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.PlayerContractToolStripMenuItem.Text = "HỢP ĐỒNG";
            // 
            // ManageCoachToolStripMenuItem
            // 
            this.ManageCoachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListCoachToolStripMenuItem,
            this.CoachContractToolStripMenuItem});
            this.ManageCoachToolStripMenuItem.Name = "ManageCoachToolStripMenuItem";
            this.ManageCoachToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.ManageCoachToolStripMenuItem.Text = "QUẢN LÝ HLV";
            // 
            // ListCoachToolStripMenuItem
            // 
            this.ListCoachToolStripMenuItem.Name = "ListCoachToolStripMenuItem";
            this.ListCoachToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.ListCoachToolStripMenuItem.Text = "DANH SÁCH HLV";
            // 
            // CoachContractToolStripMenuItem
            // 
            this.CoachContractToolStripMenuItem.Name = "CoachContractToolStripMenuItem";
            this.CoachContractToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.CoachContractToolStripMenuItem.Text = "HỢP ĐỒNG";
            // 
            // ScheduleToolStripMenuItem
            // 
            this.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem";
            this.ScheduleToolStripMenuItem.Size = new System.Drawing.Size(74, 30);
            this.ScheduleToolStripMenuItem.Text = "LỊCH";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(107, 30);
            this.HelpToolStripMenuItem.Text = "HỖ TRỢ";
            // 
            // sStrip
            // 
            this.sStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblInfor});
            this.sStrip.Location = new System.Drawing.Point(0, 996);
            this.sStrip.Name = "sStrip";
            this.sStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sStrip.Size = new System.Drawing.Size(1942, 26);
            this.sStrip.TabIndex = 1;
            this.sStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 20);
            this.toolStripStatusLabel1.Text = "Thời Gian";
            // 
            // lblInfor
            // 
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(149, 20);
            this.lblInfor.Text = "Bạn chưa đăng nhập!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1022);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStripToolBox;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.mStripToolBox.ResumeLayout(false);
            this.mStripToolBox.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
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