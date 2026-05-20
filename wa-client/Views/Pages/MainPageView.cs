using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;
using wa_client.Views;

namespace wa_client.Views.Pages
{
    public partial class MainPageView : UserControl
    {
        private List<Company> _companies = new List<Company>();
        private List<User> _users = new List<User>();
        private List<PhoneNumber> _phones = new List<PhoneNumber>();

        public MainPageView()
        {
            InitializeComponent();

            var dashboard = new DashboardView();
            dashboard.Dock = DockStyle.Fill;
            tabDashboard.Controls.Add(dashboard);
            dashboard.LoadData();

            var analytics = new AnalyticsView();
            analytics.Dock = DockStyle.Fill;
            tabAnalytics.Controls.Add(analytics);

            var billing = new BillingView();
            billing.Dock = DockStyle.Fill;
            tabLog.Controls.Add(billing);
            tabLog.Text = "Billing";

            LoadData();
        }

        public void LoadData()
        {
            LoadCompanies();
            LoadUsers();
            LoadServiceData();
        }

        private void LoadCompanies()
        {
            var response = ApiClient.Instance.Get<List<Company>>("/api/v1/companies");
            if (response.Success && response.Data != null)
            {
                _companies = response.Data;
                dgvCompany.DataSource = null;
                dgvCompany.DataSource = _companies;
                UpdateRowColors(dgvCompany, _companies.Cast<object>());
            }
        }

        private void LoadUsers()
        {
            var response = ApiClient.Instance.Get<List<User>>("/api/v1/users");
            if (response.Success && response.Data != null)
            {
                _users = response.Data;
                dgvUser.DataSource = null;
                dgvUser.DataSource = _users;
                UpdateRowColors(dgvUser, _users.Cast<object>());
            }
        }

        private void LoadServiceData()
        {
            var response = ApiClient.Instance.Get<List<PhoneNumber>>("/api/v1/phone-numbers");
            if (response.Success && response.Data != null)
            {
                _phones = response.Data;
                dgvService.DataSource = null;
                dgvService.DataSource = _phones;
                UpdateServiceRowColors();
            }
        }

        private void UpdateRowColors(DataGridView dgv, IEnumerable<object> items)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (i >= dgv.Rows.Count) break;

                dynamic obj = item;
                if (obj.IsDeleted)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                else if (obj.IsDirty)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                i++;
            }
        }

        private void UpdateServiceRowColors()
        {
            for (int i = 0; i < dgvService.Rows.Count; i++)
            {
                var phone = dgvService.Rows[i].DataBoundItem as PhoneNumber;
                if (phone == null) continue;

                if (phone.IsDeleted)
                    dgvService.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                else if (phone.IsDirty)
                    dgvService.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                else if (!phone.IsActive)
                    dgvService.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                else
                    dgvService.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvCompany_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var c = dgvCompany.Rows[e.RowIndex].DataBoundItem as Company;
            if (c != null && !c.IsNew) c.IsDirty = true;
            UpdateRowColors(dgvCompany, _companies);
        }

        private void dgvCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvCompany.CurrentRow != null)
            {
                var c = dgvCompany.CurrentRow.DataBoundItem as Company;
                if (c != null) c.IsDeleted = !c.IsDeleted;
                UpdateRowColors(dgvCompany, _companies);
            }
        }

        private void dgvUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var u = dgvUser.Rows[e.RowIndex].DataBoundItem as User;
            if (u != null && !u.IsNew) u.IsDirty = true;
            UpdateRowColors(dgvUser, _users);
        }

        private void dgvUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvUser.CurrentRow != null)
            {
                var u = dgvUser.CurrentRow.DataBoundItem as User;
                if (u != null) u.IsDeleted = !u.IsDeleted;
                UpdateRowColors(dgvUser, _users);
            }
        }

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            _companies.Add(new Company
            {
                Id = Guid.NewGuid().ToString(),
                Name = "New Company",
                Code = "NEW",
                IsActive = true,
                QuotaLimit = 1000,
                IsNew = true,
                IsDirty = true
            });
            dgvCompany.DataSource = null;
            dgvCompany.DataSource = _companies;
            UpdateRowColors(dgvCompany, _companies);
            if (dgvCompany.Rows.Count > 0)
                dgvCompany.CurrentCell = dgvCompany.Rows[_companies.Count - 1].Cells[1];
        }

        private void btnCompanySave_Click(object sender, EventArgs e)
        {
            int created = 0, updated = 0, deleted = 0;
            foreach (var c in _companies.Where(c => c.IsDirty || c.IsNew || c.IsDeleted).ToList())
            {
                if (c.IsNew)
                {
                    var r = ApiClient.Instance.Post<Company>("/api/v1/companies", c);
                    if (r.Success) created++; else MessageBox.Show($"Create failed: {r.ErrorMessage}", "Error");
                }
                else if (c.IsDeleted)
                {
                    var r = ApiClient.Instance.Delete<object>($"/api/v1/companies/{c.Id}");
                    if (r.Success) deleted++; else MessageBox.Show($"Delete failed: {r.ErrorMessage}", "Error");
                }
                else if (c.IsDirty)
                {
                    var r = ApiClient.Instance.Put<Company>($"/api/v1/companies/{c.Id}", c);
                    if (r.Success) updated++; else MessageBox.Show($"Update failed: {r.ErrorMessage}", "Error");
                }
            }
            LoadCompanies();
            if (created > 0 || updated > 0 || deleted > 0)
                MessageBox.Show($"Saved: {created} created, {updated} updated, {deleted} deleted", "Success");
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            _users.Add(new User
            {
                Id = Guid.NewGuid().ToString(),
                Email = "new@user.com",
                Name = "New User",
                Role = "cs",
                IsActive = true,
                IsNew = true,
                IsDirty = true
            });
            dgvUser.DataSource = null;
            dgvUser.DataSource = _users;
            UpdateRowColors(dgvUser, _users);
            if (dgvUser.Rows.Count > 0)
                dgvUser.CurrentCell = dgvUser.Rows[_users.Count - 1].Cells[1];
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            int created = 0, updated = 0, deleted = 0;
            foreach (var u in _users.Where(u => u.IsDirty || u.IsNew || u.IsDeleted).ToList())
            {
                if (u.IsNew)
                {
                    var r = ApiClient.Instance.Post<User>("/api/v1/users", u);
                    if (r.Success) created++; else MessageBox.Show($"Create failed: {r.ErrorMessage}", "Error");
                }
                else if (u.IsDeleted)
                {
                    var r = ApiClient.Instance.Delete<object>($"/api/v1/users/{u.Id}");
                    if (r.Success) deleted++; else MessageBox.Show($"Delete failed: {r.ErrorMessage}", "Error");
                }
                else if (u.IsDirty)
                {
                    var r = ApiClient.Instance.Put<User>($"/api/v1/users/{u.Id}", u);
                    if (r.Success) updated++; else MessageBox.Show($"Update failed: {r.ErrorMessage}", "Error");
                }
            }
            LoadUsers();
            if (created > 0 || updated > 0 || deleted > 0)
                MessageBox.Show($"Saved: {created} created, {updated} updated, {deleted} deleted", "Success");
        }

        private void btnCompanyRefresh_Click(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnServiceRefresh_Click(object sender, EventArgs e)
        {
            LoadServiceData();
        }

        private void btnServiceSync_Click(object sender, EventArgs e)
        {
            var result = ApiClient.Instance.Post<object>("/api/v1/phone-numbers/sync", null);
            if (result.Success)
                MessageBox.Show("Sync completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sync failed: " + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadServiceData();
        }

    }
}
