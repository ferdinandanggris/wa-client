namespace wa_client.Views.Pages
{
    partial class MainPageView
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

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblOutSedang = new System.Windows.Forms.Label();
            this.lblOutBelum = new System.Windows.Forms.Label();
            this.lblOutGagal = new System.Windows.Forms.Label();
            this.cboIsOutbox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.panelMasterFooter = new System.Windows.Forms.Panel();
            this.btnMasterSave = new System.Windows.Forms.Button();
            this.btnMasterAdd = new System.Windows.Forms.Button();
            this.cboMasterType = new System.Windows.Forms.ComboBox();
            this.tabService = new System.Windows.Forms.TabPage();
            this.panelService = new System.Windows.Forms.Panel();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.panelServiceFooter = new System.Windows.Forms.Panel();
            this.btnServiceSync = new System.Windows.Forms.Button();
            this.btnServiceRefresh = new System.Windows.Forms.Button();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.inboxPage = new System.Windows.Forms.TabPage();
            this.outboxPage = new System.Windows.Forms.TabPage();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.panelTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.panelMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.panelMasterFooter.SuspendLayout();
            this.tabService.SuspendLayout();
            this.panelService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panelServiceFooter.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboIsOutbox);
            this.panelTop.Controls.Add(this.lblOutSedang);
            this.panelTop.Controls.Add(this.lblOutBelum);
            this.panelTop.Controls.Add(this.lblOutGagal);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(808, 35);
            this.panelTop.TabIndex = 0;
            // 
            // cboIsOutbox
            // 
            this.cboIsOutbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIsOutbox.AutoSize = true;
            this.cboIsOutbox.Checked = true;
            this.cboIsOutbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboIsOutbox.Location = new System.Drawing.Point(550, 10);
            this.cboIsOutbox.Name = "cboIsOutbox";
            this.cboIsOutbox.Size = new System.Drawing.Size(63, 17);
            this.cboIsOutbox.TabIndex = 98;
            this.cboIsOutbox.Text = "Outbox:";
            this.cboIsOutbox.UseVisualStyleBackColor = true;
            // 
            // lblOutSedang
            // 
            this.lblOutSedang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutSedang.BackColor = System.Drawing.Color.LightCyan;
            this.lblOutSedang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutSedang.Location = new System.Drawing.Point(678, 10);
            this.lblOutSedang.Name = "lblOutSedang";
            this.lblOutSedang.Size = new System.Drawing.Size(57, 18);
            this.lblOutSedang.TabIndex = 96;
            this.lblOutSedang.Text = "0";
            this.lblOutSedang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutBelum
            // 
            this.lblOutBelum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutBelum.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblOutBelum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutBelum.Location = new System.Drawing.Point(616, 10);
            this.lblOutBelum.Name = "lblOutBelum";
            this.lblOutBelum.Size = new System.Drawing.Size(57, 18);
            this.lblOutBelum.TabIndex = 95;
            this.lblOutBelum.Text = "0";
            this.lblOutBelum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutGagal
            // 
            this.lblOutGagal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutGagal.BackColor = System.Drawing.Color.Pink;
            this.lblOutGagal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutGagal.Location = new System.Drawing.Point(741, 10);
            this.lblOutGagal.Name = "lblOutGagal";
            this.lblOutGagal.Size = new System.Drawing.Size(57, 18);
            this.lblOutGagal.TabIndex = 97;
            this.lblOutGagal.Text = "0";
            this.lblOutGagal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaster);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Controls.Add(this.tabMonitor);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 587);
            this.tabControl1.TabIndex = 16;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.panelMaster);
            this.tabMaster.Controls.Add(this.panelMasterFooter);
            this.tabMaster.Controls.Add(this.cboMasterType);
            this.tabMaster.Location = new System.Drawing.Point(4, 25);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(800, 558);
            this.tabMaster.TabIndex = 0;
            this.tabMaster.Text = "Master";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.dgvMaster);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaster.Location = new System.Drawing.Point(3, 33);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(794, 475);
            this.panelMaster.TabIndex = 2;
            // 
            // dgvMaster
            // 
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaster.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaster.Size = new System.Drawing.Size(794, 475);
            this.dgvMaster.TabIndex = 0;
            // 
            // panelMasterFooter
            // 
            this.panelMasterFooter.Controls.Add(this.btnMasterSave);
            this.panelMasterFooter.Controls.Add(this.btnMasterAdd);
            this.panelMasterFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMasterFooter.Location = new System.Drawing.Point(3, 508);
            this.panelMasterFooter.Name = "panelMasterFooter";
            this.panelMasterFooter.Size = new System.Drawing.Size(794, 47);
            this.panelMasterFooter.TabIndex = 1;
            // 
            // btnMasterSave
            // 
            this.btnMasterSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasterSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnMasterSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterSave.ForeColor = System.Drawing.Color.White;
            this.btnMasterSave.Location = new System.Drawing.Point(700, 10);
            this.btnMasterSave.Name = "btnMasterSave";
            this.btnMasterSave.Size = new System.Drawing.Size(90, 30);
            this.btnMasterSave.TabIndex = 1;
            this.btnMasterSave.Text = "Simpan";
            this.btnMasterSave.UseVisualStyleBackColor = false;
            // 
            // btnMasterAdd
            // 
            this.btnMasterAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMasterAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnMasterAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterAdd.ForeColor = System.Drawing.Color.White;
            this.btnMasterAdd.Location = new System.Drawing.Point(10, 10);
            this.btnMasterAdd.Name = "btnMasterAdd";
            this.btnMasterAdd.Size = new System.Drawing.Size(90, 30);
            this.btnMasterAdd.TabIndex = 0;
            this.btnMasterAdd.Text = "+ Tambah";
            this.btnMasterAdd.UseVisualStyleBackColor = false;
            // 
            // cboMasterType
            // 
            this.cboMasterType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMasterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular);
            this.cboMasterType.Items.AddRange(new object[] {
            "Company",
            "User"});
            this.cboMasterType.Location = new System.Drawing.Point(3, 3);
            this.cboMasterType.Name = "cboMasterType";
            this.cboMasterType.Size = new System.Drawing.Size(794, 24);
            this.cboMasterType.TabIndex = 0;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.panelService);
            this.tabService.Controls.Add(this.panelServiceFooter);
            this.tabService.Location = new System.Drawing.Point(4, 25);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(800, 558);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.dgvService);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelService.Location = new System.Drawing.Point(3, 3);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(794, 503);
            this.panelService.TabIndex = 2;
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(0, 0);
            this.dgvService.Name = "dgvService";
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(794, 503);
            this.dgvService.TabIndex = 0;
            // 
            // panelServiceFooter
            // 
            this.panelServiceFooter.Controls.Add(this.btnServiceSync);
            this.panelServiceFooter.Controls.Add(this.btnServiceRefresh);
            this.panelServiceFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelServiceFooter.Location = new System.Drawing.Point(3, 506);
            this.panelServiceFooter.Name = "panelServiceFooter";
            this.panelServiceFooter.Size = new System.Drawing.Size(794, 49);
            this.panelServiceFooter.TabIndex = 1;
            // 
            // btnServiceSync
            // 
            this.btnServiceSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnServiceSync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnServiceSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceSync.ForeColor = System.Drawing.Color.White;
            this.btnServiceSync.Location = new System.Drawing.Point(10, 10);
            this.btnServiceSync.Name = "btnServiceSync";
            this.btnServiceSync.Size = new System.Drawing.Size(120, 30);
            this.btnServiceSync.TabIndex = 1;
            this.btnServiceSync.Text = "Sync from Meta";
            this.btnServiceSync.UseVisualStyleBackColor = false;
            // 
            // btnServiceRefresh
            // 
            this.btnServiceRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnServiceRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRefresh.ForeColor = System.Drawing.Color.White;
            this.btnServiceRefresh.Location = new System.Drawing.Point(700, 10);
            this.btnServiceRefresh.Name = "btnServiceRefresh";
            this.btnServiceRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnServiceRefresh.TabIndex = 0;
            this.btnServiceRefresh.Text = "Refresh";
            this.btnServiceRefresh.UseVisualStyleBackColor = false;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.tabControl2);
            this.tabMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabMonitor.Location = new System.Drawing.Point(4, 25);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(800, 558);
            this.tabMonitor.TabIndex = 2;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.inboxPage);
            this.tabControl2.Controls.Add(this.outboxPage);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(794, 552);
            this.tabControl2.TabIndex = 0;
            // 
            // inboxPage
            // 
            this.inboxPage.Location = new System.Drawing.Point(4, 22);
            this.inboxPage.Name = "inboxPage";
            this.inboxPage.Padding = new System.Windows.Forms.Padding(3);
            this.inboxPage.Size = new System.Drawing.Size(786, 526);
            this.inboxPage.TabIndex = 0;
            this.inboxPage.Text = "Inbox";
            this.inboxPage.UseVisualStyleBackColor = true;
            // 
            // outboxPage
            // 
            this.outboxPage.Location = new System.Drawing.Point(4, 22);
            this.outboxPage.Name = "outboxPage";
            this.outboxPage.Padding = new System.Windows.Forms.Padding(3);
            this.outboxPage.Size = new System.Drawing.Size(786, 526);
            this.outboxPage.TabIndex = 1;
            this.outboxPage.Text = "Outbox";
            this.outboxPage.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            this.tabLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabLog.Location = new System.Drawing.Point(4, 25);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(800, 558);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // MainPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTop);
            this.Name = "MainPageView";
            this.Size = new System.Drawing.Size(808, 622);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMaster.ResumeLayout(false);
            this.panelMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.panelMasterFooter.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.panelService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panelServiceFooter.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        internal System.Windows.Forms.CheckBox cboIsOutbox;
        private System.Windows.Forms.Label lblOutSedang;
        private System.Windows.Forms.Label lblOutBelum;
        private System.Windows.Forms.Label lblOutGagal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMaster;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage inboxPage;
        private System.Windows.Forms.TabPage outboxPage;
        private System.Windows.Forms.ComboBox cboMasterType;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelMasterFooter;
        private System.Windows.Forms.Button btnMasterSave;
        private System.Windows.Forms.Button btnMasterAdd;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Panel panelServiceFooter;
        private System.Windows.Forms.Button btnServiceSync;
        private System.Windows.Forms.Button btnServiceRefresh;
    }
}
