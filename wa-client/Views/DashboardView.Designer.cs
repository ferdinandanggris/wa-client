namespace wa_client.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelCompanies = new System.Windows.Forms.Panel();
            this.lblCompaniesTitle = new System.Windows.Forms.Label();
            this.lblTotalCompanies = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.panelPhones = new System.Windows.Forms.Panel();
            this.lblPhonesTitle = new System.Windows.Forms.Label();
            this.lblTotalPhones = new System.Windows.Forms.Label();
            this.panelActive = new System.Windows.Forms.Panel();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.lblActivePhones = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelCompanies.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelPhones.SuspendLayout();
            this.panelActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblWelcome);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 550);
            this.panelMain.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(100, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Dashboard";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.panelCompanies);
            this.panelStats.Controls.Add(this.panelUsers);
            this.panelStats.Controls.Add(this.panelPhones);
            this.panelStats.Controls.Add(this.panelActive);
            this.panelStats.Location = new System.Drawing.Point(20, 60);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(760, 450);
            this.panelStats.TabIndex = 1;
            // 
            // panelCompanies
            // 
            this.panelCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panelCompanies.Controls.Add(this.lblCompaniesTitle);
            this.panelCompanies.Controls.Add(this.lblTotalCompanies);
            this.panelCompanies.Location = new System.Drawing.Point(0, 0);
            this.panelCompanies.Name = "panelCompanies";
            this.panelCompanies.Size = new System.Drawing.Size(180, 120);
            this.panelCompanies.TabIndex = 0;
            // 
            // lblCompaniesTitle
            // 
            this.lblCompaniesTitle.AutoSize = true;
            this.lblCompaniesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompaniesTitle.ForeColor = System.Drawing.Color.White;
            this.lblCompaniesTitle.Location = new System.Drawing.Point(15, 20);
            this.lblCompaniesTitle.Name = "lblCompaniesTitle";
            this.lblCompaniesTitle.Size = new System.Drawing.Size(85, 19);
            this.lblCompaniesTitle.TabIndex = 0;
            this.lblCompaniesTitle.Text = "Companies";
            // 
            // lblTotalCompanies
            // 
            this.lblTotalCompanies.AutoSize = true;
            this.lblTotalCompanies.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalCompanies.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompanies.Location = new System.Drawing.Point(15, 50);
            this.lblTotalCompanies.Name = "lblTotalCompanies";
            this.lblTotalCompanies.Size = new System.Drawing.Size(36, 45);
            this.lblTotalCompanies.TabIndex = 1;
            this.lblTotalCompanies.Text = "0";
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.panelUsers.Controls.Add(this.lblUsersTitle);
            this.panelUsers.Controls.Add(this.lblTotalUsers);
            this.panelUsers.Location = new System.Drawing.Point(190, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(180, 120);
            this.panelUsers.TabIndex = 1;
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.AutoSize = true;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsersTitle.ForeColor = System.Drawing.Color.White;
            this.lblUsersTitle.Location = new System.Drawing.Point(15, 20);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(47, 19);
            this.lblUsersTitle.TabIndex = 0;
            this.lblUsersTitle.Text = "Users";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsers.ForeColor = System.Drawing.Color.White;
            this.lblTotalUsers.Location = new System.Drawing.Point(15, 50);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(36, 45);
            this.lblTotalUsers.TabIndex = 1;
            this.lblTotalUsers.Text = "0";
            // 
            // panelPhones
            // 
            this.panelPhones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelPhones.Controls.Add(this.lblPhonesTitle);
            this.panelPhones.Controls.Add(this.lblTotalPhones);
            this.panelPhones.Location = new System.Drawing.Point(380, 0);
            this.panelPhones.Name = "panelPhones";
            this.panelPhones.Size = new System.Drawing.Size(180, 120);
            this.panelPhones.TabIndex = 2;
            // 
            // lblPhonesTitle
            // 
            this.lblPhonesTitle.AutoSize = true;
            this.lblPhonesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhonesTitle.ForeColor = System.Drawing.Color.White;
            this.lblPhonesTitle.Location = new System.Drawing.Point(15, 20);
            this.lblPhonesTitle.Name = "lblPhonesTitle";
            this.lblPhonesTitle.Size = new System.Drawing.Size(99, 19);
            this.lblPhonesTitle.TabIndex = 0;
            this.lblPhonesTitle.Text = "Phone Numbers";
            // 
            // lblTotalPhones
            // 
            this.lblTotalPhones.AutoSize = true;
            this.lblTotalPhones.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalPhones.ForeColor = System.Drawing.Color.White;
            this.lblTotalPhones.Location = new System.Drawing.Point(15, 50);
            this.lblTotalPhones.Name = "lblTotalPhones";
            this.lblTotalPhones.Size = new System.Drawing.Size(36, 45);
            this.lblTotalPhones.TabIndex = 1;
            this.lblTotalPhones.Text = "0";
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panelActive.Controls.Add(this.lblActiveTitle);
            this.panelActive.Controls.Add(this.lblActivePhones);
            this.panelActive.Location = new System.Drawing.Point(570, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(180, 120);
            this.panelActive.TabIndex = 3;
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.White;
            this.lblActiveTitle.Location = new System.Drawing.Point(15, 20);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(109, 19);
            this.lblActiveTitle.TabIndex = 0;
            this.lblActiveTitle.Text = "Active Phones";
            // 
            // lblActivePhones
            // 
            this.lblActivePhones.AutoSize = true;
            this.lblActivePhones.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblActivePhones.ForeColor = System.Drawing.Color.White;
            this.lblActivePhones.Location = new System.Drawing.Point(15, 50);
            this.lblActivePhones.Name = "lblActivePhones";
            this.lblActivePhones.Size = new System.Drawing.Size(36, 45);
            this.lblActivePhones.TabIndex = 1;
            this.lblActivePhones.Text = "0";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(800, 550);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelCompanies.ResumeLayout(false);
            this.panelCompanies.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelPhones.ResumeLayout(false);
            this.panelPhones.PerformLayout();
            this.panelActive.ResumeLayout(false);
            this.panelActive.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelCompanies;
        private System.Windows.Forms.Label lblCompaniesTitle;
        private System.Windows.Forms.Label lblTotalCompanies;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Panel panelPhones;
        private System.Windows.Forms.Label lblPhonesTitle;
        private System.Windows.Forms.Label lblTotalPhones;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblActivePhones;
    }
}