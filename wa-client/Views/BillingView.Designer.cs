namespace wa_client.Views
{
    partial class BillingView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpQuota = new System.Windows.Forms.GroupBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblRemainingVal = new System.Windows.Forms.Label();
            this.lblUsed = new System.Windows.Forms.Label();
            this.lblUsedVal = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblLimitVal = new System.Windows.Forms.Label();
            this.btnCheckQuota = new System.Windows.Forms.Button();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.lblSelectCompany = new System.Windows.Forms.Label();
            this.grpCostSummary = new System.Windows.Forms.GroupBox();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.btnLoadSummary = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.grpQuota.SuspendLayout();
            this.grpCostSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(800, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Billing Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.grpQuota.Controls.Add(this.lblRemaining);
            this.grpQuota.Controls.Add(this.lblRemainingVal);
            this.grpQuota.Controls.Add(this.lblUsed);
            this.grpQuota.Controls.Add(this.lblUsedVal);
            this.grpQuota.Controls.Add(this.lblLimit);
            this.grpQuota.Controls.Add(this.lblLimitVal);
            this.grpQuota.Controls.Add(this.btnCheckQuota);
            this.grpQuota.Controls.Add(this.cboCompany);
            this.grpQuota.Controls.Add(this.lblSelectCompany);
            this.grpQuota.Location = new System.Drawing.Point(12, 45);
            this.grpQuota.Name = "grpQuota";
            this.grpQuota.Size = new System.Drawing.Size(776, 100);
            this.grpQuota.TabIndex = 1;
            this.grpQuota.TabStop = false;
            this.grpQuota.Text = "Quota";

            this.lblSelectCompany.AutoSize = true;
            this.lblSelectCompany.Location = new System.Drawing.Point(15, 30);
            this.lblSelectCompany.Name = "lblSelectCompany";
            this.lblSelectCompany.Size = new System.Drawing.Size(54, 13);
            this.lblSelectCompany.TabIndex = 0;
            this.lblSelectCompany.Text = "Company:";

            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Location = new System.Drawing.Point(80, 27);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(200, 21);
            this.cboCompany.TabIndex = 1;

            this.btnCheckQuota.Location = new System.Drawing.Point(295, 25);
            this.btnCheckQuota.Name = "btnCheckQuota";
            this.btnCheckQuota.Size = new System.Drawing.Size(90, 23);
            this.btnCheckQuota.TabIndex = 2;
            this.btnCheckQuota.Text = "Check Quota";
            this.btnCheckQuota.UseVisualStyleBackColor = true;
            this.btnCheckQuota.Click += new System.EventHandler(this.btnCheckQuota_Click);

            this.lblLimitVal.AutoSize = true;
            this.lblLimitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLimitVal.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblLimitVal.Location = new System.Drawing.Point(420, 30);
            this.lblLimitVal.Name = "lblLimitVal";
            this.lblLimitVal.Size = new System.Drawing.Size(15, 15);
            this.lblLimitVal.TabIndex = 3;
            this.lblLimitVal.Text = "0";

            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(420, 15);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(31, 13);
            this.lblLimit.TabIndex = 4;
            this.lblLimit.Text = "Limit";

            this.lblUsedVal.AutoSize = true;
            this.lblUsedVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsedVal.ForeColor = System.Drawing.Color.FromArgb(204, 102, 0);
            this.lblUsedVal.Location = new System.Drawing.Point(520, 30);
            this.lblUsedVal.Name = "lblUsedVal";
            this.lblUsedVal.Size = new System.Drawing.Size(15, 15);
            this.lblUsedVal.TabIndex = 5;
            this.lblUsedVal.Text = "0";

            this.lblUsed.AutoSize = true;
            this.lblUsed.Location = new System.Drawing.Point(520, 15);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(31, 13);
            this.lblUsed.TabIndex = 6;
            this.lblUsed.Text = "Used";

            this.lblRemainingVal.AutoSize = true;
            this.lblRemainingVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemainingVal.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblRemainingVal.Location = new System.Drawing.Point(620, 30);
            this.lblRemainingVal.Name = "lblRemainingVal";
            this.lblRemainingVal.Size = new System.Drawing.Size(15, 15);
            this.lblRemainingVal.TabIndex = 7;
            this.lblRemainingVal.Text = "0";

            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(620, 15);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(58, 13);
            this.lblRemaining.TabIndex = 8;
            this.lblRemaining.Text = "Remaining";

            this.grpCostSummary.Controls.Add(this.dgvSummary);
            this.grpCostSummary.Controls.Add(this.btnLoadSummary);
            this.grpCostSummary.Controls.Add(this.dtpEnd);
            this.grpCostSummary.Controls.Add(this.lblEnd);
            this.grpCostSummary.Controls.Add(this.dtpStart);
            this.grpCostSummary.Controls.Add(this.lblStart);
            this.grpCostSummary.Location = new System.Drawing.Point(12, 155);
            this.grpCostSummary.Name = "grpCostSummary";
            this.grpCostSummary.Size = new System.Drawing.Size(776, 450);
            this.grpCostSummary.TabIndex = 2;
            this.grpCostSummary.TabStop = false;
            this.grpCostSummary.Text = "Cost Summary";

            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(15, 25);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(30, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start:";

            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(50, 22);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 20);
            this.dtpStart.TabIndex = 1;

            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(185, 25);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(27, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "End:";

            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(215, 22);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 20);
            this.dtpEnd.TabIndex = 3;

            this.btnLoadSummary.Location = new System.Drawing.Point(350, 20);
            this.btnLoadSummary.Name = "btnLoadSummary";
            this.btnLoadSummary.Size = new System.Drawing.Size(100, 23);
            this.btnLoadSummary.TabIndex = 4;
            this.btnLoadSummary.Text = "Load Summary";
            this.btnLoadSummary.UseVisualStyleBackColor = true;
            this.btnLoadSummary.Click += new System.EventHandler(this.btnLoadSummary_Click);

            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.AllowUserToDeleteRows = false;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSummary.Location = new System.Drawing.Point(3, 55);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSummary.Size = new System.Drawing.Size(770, 392);
            this.dgvSummary.TabIndex = 5;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCostSummary);
            this.Controls.Add(this.grpQuota);
            this.Controls.Add(this.lblTitle);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(800, 620);
            this.grpQuota.ResumeLayout(false);
            this.grpQuota.PerformLayout();
            this.grpCostSummary.ResumeLayout(false);
            this.grpCostSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpQuota;
        private System.Windows.Forms.Label lblSelectCompany;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Button btnCheckQuota;
        private System.Windows.Forms.Label lblLimitVal;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblUsedVal;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.Label lblRemainingVal;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.GroupBox grpCostSummary;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnLoadSummary;
        private System.Windows.Forms.DataGridView dgvSummary;
    }
}
