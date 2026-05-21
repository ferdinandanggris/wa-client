using System;
using System.Drawing;
using System.Windows.Forms;
using wa_client.Services;

namespace wa_client.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Email and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            lblStatus.Text = "Logging in...";

            try
            {
                var response = AuthService.Instance.Login(txtEmail.Text.Trim(), txtPassword.Text);

                if (response.Success)
                {
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Login failed: {response.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                lblStatus.Text = "";
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}