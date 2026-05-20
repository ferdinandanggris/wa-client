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
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.panelCompany = new System.Windows.Forms.Panel();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.panelCompanyFooter = new System.Windows.Forms.Panel();
            this.btnCompanySave = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.panelUser = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panelUserFooter = new System.Windows.Forms.Panel();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.tabService = new System.Windows.Forms.TabPage();
            this.panelService = new System.Windows.Forms.Panel();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.panelServiceFooter = new System.Windows.Forms.Panel();
            this.btnServiceRefresh = new System.Windows.Forms.Button();
            this.btnServiceSync = new System.Windows.Forms.Button();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.inboxPage = new System.Windows.Forms.TabPage();
            this.outboxPage = new System.Windows.Forms.TabPage();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.panelTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCompany.SuspendLayout();
            this.panelCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.panelCompanyFooter.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panelUserFooter.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabCompany);
            this.tabControl1.Controls.Add(this.tabUser);
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
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.panelCompany);
            this.tabCompany.Controls.Add(this.panelCompanyFooter);
            this.tabCompany.Controls.Add(this.lblCompanyTitle);
            this.tabCompany.Location = new System.Drawing.Point(4, 25);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompany.Size = new System.Drawing.Size(800, 558);
            this.tabCompany.TabIndex = 0;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // panelCompany
            // 
            this.panelCompany.Controls.Add(this.dgvCompany);
            this.panelCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCompany.Location = new System.Drawing.Point(3, 33);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(794, 475);
            this.panelCompany.TabIndex = 2;
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToDeleteRows = false;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvCompany.Location = new System.Drawing.Point(0, 0);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompany.Size = new System.Drawing.Size(794, 475);
            this.dgvCompany.TabIndex = 0;
            this.dgvCompany.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellValueChanged);
            this.dgvCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCompany_KeyDown);
            // 
            // panelCompanyFooter
            // 
            this.panelCompanyFooter.Controls.Add(this.btnCompanyRefresh);
            this.panelCompanyFooter.Controls.Add(this.btnCompanySave);
            this.panelCompanyFooter.Controls.Add(this.btnCompanyAdd);
            this.panelCompanyFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCompanyFooter.Location = new System.Drawing.Point(3, 508);
            this.panelCompanyFooter.Name = "panelCompanyFooter";
            this.panelCompanyFooter.Size = new System.Drawing.Size(794, 47);
            this.panelCompanyFooter.TabIndex = 1;
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompanySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCompanySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanySave.ForeColor = System.Drawing.Color.White;
            this.btnCompanySave.Location = new System.Drawing.Point(700, 10);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(90, 30);
            this.btnCompanySave.TabIndex = 1;
            this.btnCompanySave.Text = "Simpan";
            this.btnCompanySave.UseVisualStyleBackColor = false;
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            // 
            // btnCompanyRefresh
            // 
            this.btnCompanyRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompanyRefresh.BackColor = System.Drawing.Color.White;
            this.btnCompanyRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyRefresh.Location = new System.Drawing.Point(600, 10);
            this.btnCompanyRefresh.Name = "btnCompanyRefresh";
            this.btnCompanyRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnCompanyRefresh.TabIndex = 2;
            this.btnCompanyRefresh.Text = "F5 - Refresh";
            this.btnCompanyRefresh.UseVisualStyleBackColor = false;
            this.btnCompanyRefresh.Click += new System.EventHandler(this.btnCompanyRefresh_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCompanyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompanyAdd.ForeColor = System.Drawing.Color.White;
            this.btnCompanyAdd.Location = new System.Drawing.Point(10, 10);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(90, 30);
            this.btnCompanyAdd.TabIndex = 0;
            this.btnCompanyAdd.Text = "+ Tambah";
            this.btnCompanyAdd.UseVisualStyleBackColor = false;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // lblCompanyTitle
            // 
            this.lblCompanyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCompanyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCompanyTitle.Location = new System.Drawing.Point(3, 3);
            this.lblCompanyTitle.Name = "lblCompanyTitle";
            this.lblCompanyTitle.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.lblCompanyTitle.Size = new System.Drawing.Size(794, 30);
            this.lblCompanyTitle.TabIndex = 3;
            this.lblCompanyTitle.Text = "Company Management";
            this.lblCompanyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.panelUser);
            this.tabUser.Controls.Add(this.panelUserFooter);
            this.tabUser.Controls.Add(this.lblUserTitle);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(800, 558);
            this.tabUser.TabIndex = 4;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.dgvUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(3, 33);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(794, 475);
            this.panelUser.TabIndex = 2;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(794, 475);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellValueChanged);
            this.dgvUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUser_KeyDown);
            // 
            // panelUserFooter
            // 
            this.panelUserFooter.Controls.Add(this.btnUserRefresh);
            this.panelUserFooter.Controls.Add(this.btnUserSave);
            this.panelUserFooter.Controls.Add(this.btnUserAdd);
            this.panelUserFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserFooter.Location = new System.Drawing.Point(3, 508);
            this.panelUserFooter.Name = "panelUserFooter";
            this.panelUserFooter.Size = new System.Drawing.Size(794, 47);
            this.panelUserFooter.TabIndex = 1;
            // 
            // btnUserSave
            // 
            this.btnUserSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSave.ForeColor = System.Drawing.Color.White;
            this.btnUserSave.Location = new System.Drawing.Point(700, 10);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(90, 30);
            this.btnUserSave.TabIndex = 1;
            this.btnUserSave.Text = "Simpan";
            this.btnUserSave.UseVisualStyleBackColor = false;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserRefresh
            // 
            this.btnUserRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserRefresh.BackColor = System.Drawing.Color.White;
            this.btnUserRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRefresh.Location = new System.Drawing.Point(600, 10);
            this.btnUserRefresh.Name = "btnUserRefresh";
            this.btnUserRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnUserRefresh.TabIndex = 2;
            this.btnUserRefresh.Text = "F5 - Refresh";
            this.btnUserRefresh.UseVisualStyleBackColor = false;
            this.btnUserRefresh.Click += new System.EventHandler(this.btnUserRefresh_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.ForeColor = System.Drawing.Color.White;
            this.btnUserAdd.Location = new System.Drawing.Point(10, 10);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(90, 30);
            this.btnUserAdd.TabIndex = 0;
            this.btnUserAdd.Text = "+ Tambah";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserTitle.Location = new System.Drawing.Point(3, 3);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.lblUserTitle.Size = new System.Drawing.Size(794, 30);
            this.lblUserTitle.TabIndex = 3;
            this.lblUserTitle.Text = "User Management";
            this.lblUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tabService.Text = "Phone Numbers";
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
            this.dgvService.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvService_CellFormatting);
            // 
            // panelServiceFooter
            // 
            this.panelServiceFooter.Controls.Add(this.btnServiceRefresh);
            this.panelServiceFooter.Controls.Add(this.btnServiceSync);
            this.panelServiceFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelServiceFooter.Location = new System.Drawing.Point(3, 506);
            this.panelServiceFooter.Name = "panelServiceFooter";
            this.panelServiceFooter.Size = new System.Drawing.Size(794, 49);
            this.panelServiceFooter.TabIndex = 1;
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
            this.btnServiceRefresh.Click += new System.EventHandler(this.btnServiceRefresh_Click);
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
            this.btnServiceSync.Click += new System.EventHandler(this.btnServiceSync_Click);
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
            this.tabCompany.ResumeLayout(false);
            this.panelCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.panelCompanyFooter.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panelUserFooter.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage inboxPage;
        private System.Windows.Forms.TabPage outboxPage;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.Panel panelCompany;
        private System.Windows.Forms.Panel panelCompanyFooter;
        private System.Windows.Forms.Button btnCompanySave;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Button btnCompanyRefresh;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelUserFooter;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserRefresh;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Panel panelServiceFooter;
        private System.Windows.Forms.Button btnServiceRefresh;
        private System.Windows.Forms.Button btnServiceSync;
    }
}
