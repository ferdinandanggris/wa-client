using System;
using System.Linq;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;

namespace wa_client.Forms
{
    public partial class ProfileEditForm : Form
    {
        private readonly string _phoneId;
        private readonly string _phoneNumber;

        public ProfileEditForm(string phoneId, string phoneNumber)
        {
            InitializeComponent();
            _phoneId = phoneId;
            _phoneNumber = phoneNumber;
            lblPhone.Text = "Phone: " + _phoneNumber;
            LoadProfile();
        }

        private void LoadProfile()
        {
            var response = ApiClient.Instance.Get<PhoneNumberProfile>($"/api/v1/phone-numbers/{_phoneId}/profile");
            if (response.Success && response.Data != null)
            {
                txtAbout.Text = response.Data.About ?? "";
                txtAddress.Text = response.Data.Address ?? "";
                txtDescription.Text = response.Data.Description ?? "";
                txtEmail.Text = response.Data.Email ?? "";
                txtWebsites.Text = response.Data.Websites != null ? string.Join(", ", response.Data.Websites) : "";
                txtVertical.Text = response.Data.Vertical ?? "";
            }
            else
            {
                MessageBox.Show("Failed to load profile: " + response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            var profile = new
            {
                about = txtAbout.Text.Trim(),
                address = txtAddress.Text.Trim(),
                description = txtDescription.Text.Trim(),
                email = txtEmail.Text.Trim(),
                websites = txtWebsites.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.Trim()).ToArray(),
                vertical = txtVertical.Text.Trim()
            };

            var result = ApiClient.Instance.Put<object>($"/api/v1/phone-numbers/{_phoneId}/profile", profile);
            if (result.Success)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update profile: " + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
