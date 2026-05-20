namespace wa_client.Views
{
    partial class AnalyticsView
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
            this.lblAnalytics = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblAnalytics);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 550);
            this.panelMain.TabIndex = 0;
            // 
            // lblAnalytics
            // 
            this.lblAnalytics.AutoSize = true;
            this.lblAnalytics.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAnalytics.Location = new System.Drawing.Point(20, 20);
            this.lblAnalytics.Name = "lblAnalytics";
            this.lblAnalytics.Size = new System.Drawing.Size(100, 32);
            this.lblAnalytics.TabIndex = 0;
            this.lblAnalytics.Text = "Analytics";
            // 
            // AnalyticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "AnalyticsView";
            this.Size = new System.Drawing.Size(800, 550);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblAnalytics;
    }
}