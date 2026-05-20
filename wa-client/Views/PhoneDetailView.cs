using System;
using System.Drawing;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;

namespace wa_client.Views
{
    public partial class PhoneDetailView : UserControl
    {
        private PhoneNumber _phone;
        private int labelWidth = 150;
        private int valueWidth = 300;

        public PhoneDetailView(PhoneNumber phone)
        {
            _phone = phone;
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            Label lblHeader = new Label();
            lblHeader.Text = $"Phone Number Detail";
            lblHeader.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblHeader.Location = new Point(20, 20);
            lblHeader.AutoSize = true;
            this.Controls.Add(lblHeader);

            int yPos = 70;
            labelWidth = 150;
            valueWidth = 300;

            AddLabelPair("ID:", _phone.Id, ref yPos);
            AddLabelPair("Phone Number:", _phone.PhoneNumberVal, ref yPos);
            AddLabelPair("Phone Number ID:", _phone.PhoneNumberId, ref yPos);
            AddLabelPair("Active:", _phone.IsActive ? "Yes" : "No", ref yPos);
            AddLabelPair("Last Sync Pricing:", new DateTime(1970,1,1).AddSeconds(_phone.LastSyncPricing).ToString("yyyy-MM-dd HH:mm"), ref yPos);
            AddLabelPair("Created:", _phone.CreatedAt, ref yPos);
            AddLabelPair("Updated:", _phone.UpdatedAt, ref yPos);

            Button btnBack = new Button();
            btnBack.Text = "Back to List";
            btnBack.Location = new Point(20, yPos + 20);
            btnBack.Click += (s, e) => this.Parent.Controls.Remove(this);
            this.Controls.Add(btnBack);

            this.ResumeLayout(false);
        }

        private void AddLabelPair(string label, string value, ref int yPos)
        {
            Label lbl = new Label();
            lbl.Text = label;
            lbl.Location = new Point(20, yPos);
            lbl.Width = labelWidth;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.Controls.Add(lbl);

            Label val = new Label();
            val.Text = value ?? "-";
            val.Location = new Point(20 + labelWidth, yPos);
            val.Width = valueWidth;
            this.Controls.Add(val);

            yPos += 30;
        }

        private void LoadData()
        {
        }
    }
}