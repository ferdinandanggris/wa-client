namespace wa_client.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alatPengujiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesKoneksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirimBroadcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelSidebarTop = new System.Windows.Forms.Panel();
            this.btnCollapseRight = new System.Windows.Forms.PictureBox();
            this.btnCollapseLeft = new System.Windows.Forms.PictureBox();
            this.lblModul = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.panelContent = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelSidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollapseRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollapseLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.alatPengujiToolStripMenuItem,
            this.kirimBroadcastToolStripMenuItem,
            this.tentangAplikasiToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1000, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengaturanToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator2,
            this.keluarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // alatPengujiToolStripMenuItem
            // 
            this.alatPengujiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tesKoneksiToolStripMenuItem});
            this.alatPengujiToolStripMenuItem.Name = "alatPengujiToolStripMenuItem";
            this.alatPengujiToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.alatPengujiToolStripMenuItem.Text = "Alat Penguji";
            // 
            // tesKoneksiToolStripMenuItem
            // 
            this.tesKoneksiToolStripMenuItem.Name = "tesKoneksiToolStripMenuItem";
            this.tesKoneksiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.tesKoneksiToolStripMenuItem.Text = "Tes Koneksi";
            // 
            // kirimBroadcastToolStripMenuItem
            // 
            this.kirimBroadcastToolStripMenuItem.Name = "kirimBroadcastToolStripMenuItem";
            this.kirimBroadcastToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.kirimBroadcastToolStripMenuItem.Text = "Kirim Broadcast";
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tentangAplikasiToolStripMenuItem.Text = "Bantuan";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelSidebarTop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tvMenu);
            this.splitContainer.Size = new System.Drawing.Size(250, 576);
            this.splitContainer.SplitterDistance = 70;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 1;
            // 
            // panelSidebarTop
            // 
            this.panelSidebarTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelSidebarTop.Controls.Add(this.btnCollapseRight);
            this.panelSidebarTop.Controls.Add(this.btnCollapseLeft);
            this.panelSidebarTop.Controls.Add(this.lblModul);
            this.panelSidebarTop.Controls.Add(this.pictureLogo);
            this.panelSidebarTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebarTop.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarTop.Name = "panelSidebarTop";
            this.panelSidebarTop.Size = new System.Drawing.Size(246, 66);
            this.panelSidebarTop.TabIndex = 0;
            // 
            // btnCollapseRight
            // 
            this.btnCollapseRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCollapseRight.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCollapseRight.Location = new System.Drawing.Point(226, 22);
            this.btnCollapseRight.Name = "btnCollapseRight";
            this.btnCollapseRight.Size = new System.Drawing.Size(20, 20);
            this.btnCollapseRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCollapseRight.TabIndex = 2;
            this.btnCollapseRight.TabStop = false;
            this.btnCollapseRight.Click += new System.EventHandler(this.btnCollapseRight_Click);
            // 
            // btnCollapseLeft
            // 
            this.btnCollapseLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCollapseLeft.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCollapseLeft.Location = new System.Drawing.Point(0, 22);
            this.btnCollapseLeft.Name = "btnCollapseLeft";
            this.btnCollapseLeft.Size = new System.Drawing.Size(20, 20);
            this.btnCollapseLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCollapseLeft.TabIndex = 1;
            this.btnCollapseLeft.TabStop = false;
            this.btnCollapseLeft.Click += new System.EventHandler(this.btnCollapseLeft_Click);
            // 
            // lblModul
            // 
            this.lblModul.BackColor = System.Drawing.Color.SkyBlue;
            this.lblModul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblModul.Location = new System.Drawing.Point(0, 0);
            this.lblModul.Name = "lblModul";
            this.lblModul.Size = new System.Drawing.Size(246, 46);
            this.lblModul.TabIndex = 0;
            this.lblModul.Text = "M O D U L";
            this.lblModul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureLogo.Location = new System.Drawing.Point(0, 46);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(246, 20);
            this.pictureLogo.TabIndex = 3;
            this.pictureLogo.TabStop = false;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HotTracking = true;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(246, 501);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            this.tvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseDoubleClick);
            this.tvMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvMenu_MouseDown);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(750, 526);
            this.panelContent.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblVersion,
            this.lblDateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(750, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // lblVersion
            // 
            this.lblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 17);
            this.lblVersion.Text = "v 1.0.0";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(95, 17);
            this.lblDateTime.Text = "20/05/2026 10:00";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WA Gateway Admin";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelSidebarTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCollapseRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollapseLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alatPengujiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesKoneksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirimBroadcastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangAplikasiToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelSidebarTop;
        private System.Windows.Forms.PictureBox btnCollapseRight;
        private System.Windows.Forms.PictureBox btnCollapseLeft;
        private System.Windows.Forms.Label lblModul;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}