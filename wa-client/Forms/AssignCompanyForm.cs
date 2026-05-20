using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;

namespace wa_client.Forms
{
    public partial class AssignCompanyForm : Form
    {
        private readonly string _phoneId;
        private readonly string _phoneNumber;
        private List<Company> _companies;

        public AssignCompanyForm(string phoneId, string phoneNumber)
        {
            InitializeComponent();
            _phoneId = phoneId;
            _phoneNumber = phoneNumber;
            lblPhone.Text = "Phone: " + _phoneNumber;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCompany.SelectedValue == null)
            {
                MessageBox.Show("Please select a company", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var companyId = cboCompany.SelectedValue.ToString();
            btnSave.Enabled = false;

            var result = ApiClient.Instance.Post<object>($"/api/v1/phone-numbers/{_phoneId}/assign", new { company_id = companyId });
            if (result.Success)
            {
                MessageBox.Show("Phone number assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to assign: " + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
