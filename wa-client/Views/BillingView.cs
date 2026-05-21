using System;
using System.Collections.Generic;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;

namespace wa_client.Views
{
    public partial class BillingView : UserControl
    {
        private List<Company> _companies;

        public BillingView()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Now.AddDays(-7);
            dtpEnd.Value = DateTime.Now;
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            var response = ApiClient.Instance.Get<List<Company>>("/api/v1/companies");
            if (response.Success && response.Data != null)
            {
                _companies = response.Data;
                cboCompany.DisplayMember = "Name";
                cboCompany.ValueMember = "Id";
                cboCompany.DataSource = _companies;
            }
            else
            {
                MessageBox.Show("Failed to load companies: " + response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckQuota_Click(object sender, EventArgs e)
        {
            if (cboCompany.SelectedValue == null)
            {
                MessageBox.Show("Please select a company first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var companyId = cboCompany.SelectedValue.ToString();
            var response = ApiClient.Instance.Get<BillingQuota>($"/api/v1/billing/quota?company_id={companyId}");
            if (response.Success && response.Data != null)
            {
                lblLimit.Text = response.Data.QuotaLimit.ToString("N0");
                lblUsed.Text = response.Data.QuotaUsed.ToString("N0");
                lblRemaining.Text = response.Data.Remaining.ToString("N0");
            }
            else
            {
                MessageBox.Show("Failed: " + response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadSummary_Click(object sender, EventArgs e)
        {
            var start = dtpStart.Value.Date.ToString("yyyy-MM-dd") + "T00:00:00Z";
            var end = dtpEnd.Value.Date.AddDays(1).ToString("yyyy-MM-dd") + "T00:00:00Z";
            var response = ApiClient.Instance.Get<List<BillingCostSummaryItem>>($"/api/v1/billing/cost-summary?start={start}&end={end}");
            if (response.Success && response.Data != null)
            {
                dgvSummary.DataSource = null;
                dgvSummary.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show("Failed: " + response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
