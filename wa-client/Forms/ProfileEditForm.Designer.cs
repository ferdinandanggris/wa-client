namespace wa_client.Forms
{
    partial class ProfileEditForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVertical = new System.Windows.Forms.TextBox();
            this.lblVertical = new System.Windows.Forms.Label();
            this.txtWebsites = new System.Windows.Forms.TextBox();
            this.lblWebsites = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.txtVertical);
            this.panelMain.Controls.Add(this.lblVertical);
            this.panelMain.Controls.Add(this.txtWebsites);
            this.panelMain.Controls.Add(this.lblWebsites);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.txtDescription);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.txtAddress);
            this.panelMain.Controls.Add(this.lblAddress);
            this.panelMain.Controls.Add(this.txtAbout);
            this.panelMain.Controls.Add(this.lblAbout);
            this.panelMain.Controls.Add(this.lblPhone);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(460, 400);
            this.panelMain.TabIndex = 0;

            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(20, 20);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(420, 20);
            this.lblPhone.TabIndex = 0;

            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(20, 55);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(38, 13);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "About:";

            this.txtAbout.Location = new System.Drawing.Point(23, 72);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(417, 20);
            this.txtAbout.TabIndex = 2;

            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";

            this.txtAddress.Location = new System.Drawing.Point(23, 117);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(417, 20);
            this.txtAddress.TabIndex = 4;

            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";

            this.txtDescription.Location = new System.Drawing.Point(23, 162);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(417, 20);
            this.txtDescription.TabIndex = 6;

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";

            this.txtEmail.Location = new System.Drawing.Point(23, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 20);
            this.txtEmail.TabIndex = 8;

            this.lblWebsites.AutoSize = true;
            this.lblWebsites.Location = new System.Drawing.Point(20, 235);
            this.lblWebsites.Name = "lblWebsites";
            this.lblWebsites.Size = new System.Drawing.Size(55, 13);
            this.lblWebsites.TabIndex = 9;
            this.lblWebsites.Text = "Websites:";

            this.txtWebsites.Location = new System.Drawing.Point(23, 252);
            this.txtWebsites.Name = "txtWebsites";
            this.txtWebsites.Size = new System.Drawing.Size(417, 20);
            this.txtWebsites.TabIndex = 10;
            this.txtWebsites.Text = "comma, separated";

            this.lblVertical.AutoSize = true;
            this.lblVertical.Location = new System.Drawing.Point(20, 280);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(45, 13);
            this.lblVertical.TabIndex = 11;
            this.lblVertical.Text = "Vertical:";

            this.txtVertical.Location = new System.Drawing.Point(23, 297);
            this.txtVertical.Name = "txtVertical";
            this.txtVertical.Size = new System.Drawing.Size(417, 20);
            this.txtVertical.TabIndex = 12;

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(285, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(365, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Profile";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblWebsites;
        private System.Windows.Forms.TextBox txtWebsites;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.TextBox txtVertical;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
