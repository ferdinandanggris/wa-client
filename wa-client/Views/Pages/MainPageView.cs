using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;

namespace wa_client.Views.Pages
{
    public partial class MainPageView : UserControl
    {
        private List<Company> _companies = new List<Company>();
        private List<User> _users = new List<User>();
        private List<PhoneNumber> _phones = new List<PhoneNumber>();
        private bool _isCompanyMode = true;

        public MainPageView()
        {
            InitializeComponent();
            cboMasterType.SelectedIndexChanged += CboMasterType_SelectedIndexChanged;
            dgvMaster.CellValueChanged += DgvMaster_CellValueChanged;
            dgvMaster.KeyDown += DgvMaster_KeyDown;
            dgvService.CellFormatting += DgvService_CellFormatting;
            btnMasterAdd.Click += BtnMasterAdd_Click;
            btnMasterSave.Click += BtnMasterSave_Click;
            btnServiceRefresh.Click += BtnServiceRefresh_Click;
            btnServiceSync.Click += BtnServiceSync_Click;
            cboMasterType.SelectedIndex = 0;
            LoadMasterData();
            LoadServiceData();
        }

        private void CboMasterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isCompanyMode = cboMasterType.SelectedItem?.ToString() == "Company";
            LoadMasterData();
        }

        public void LoadData()
        {
            LoadMasterData();
            LoadServiceData();
        }

        private void LoadMasterData()
        {
            if (_isCompanyMode)
                LoadCompanies();
            else
                LoadUsers();
        }

        private void LoadCompanies()
        {
            var response = ApiClient.Instance.Get<List<Company>>("/api/v1/companies");
            if (response.Success && response.Data != null)
            {
                _companies = response.Data;
                dgvMaster.DataSource = null;
                dgvMaster.DataSource = _companies;
                UpdateMasterRowColors();
            }
        }

        private void LoadUsers()
        {
            var response = ApiClient.Instance.Get<List<User>>("/api/v1/users");
            if (response.Success && response.Data != null)
            {
                _users = response.Data;
                dgvMaster.DataSource = null;
                dgvMaster.DataSource = _users;
                UpdateMasterRowColors();
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

        private void UpdateMasterRowColors()
        {
            for (int i = 0; i < dgvMaster.Rows.Count; i++)
            {
                object item = dgvMaster.Rows[i].DataBoundItem;
                if (item == null) continue;

                if (_isCompanyMode)
                {
                    var c = item as Company;
                    if (c == null) continue;
                    if (c.IsDeleted)
                        dgvMaster.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    else if (c.IsDirty)
                        dgvMaster.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgvMaster.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    var u = item as User;
                    if (u == null) continue;
                    if (u.IsDeleted)
                        dgvMaster.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    else if (u.IsDirty)
                        dgvMaster.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgvMaster.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
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

        private void DgvService_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvService.Columns[e.ColumnIndex].DataPropertyName == "IsActive")
            {
                e.Value = (bool)e.Value ? "Active" : "Inactive";
                e.FormattingApplied = true;
            }
        }

        private void DgvMaster_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            object item = dgvMaster.Rows[e.RowIndex].DataBoundItem;
            if (item == null) return;

            if (_isCompanyMode)
            {
                var c = item as Company;
                if (c != null && !c.IsNew) c.IsDirty = true;
            }
            else
            {
                var u = item as User;
                if (u != null && !u.IsNew) u.IsDirty = true;
            }
            UpdateMasterRowColors();
        }

        private void DgvMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvMaster.CurrentRow != null)
            {
                object item = dgvMaster.CurrentRow.DataBoundItem;
                if (item is Company c) c.IsDeleted = !c.IsDeleted;
                else if (item is User u) u.IsDeleted = !u.IsDeleted;
                UpdateMasterRowColors();
            }
        }

        private void BtnMasterAdd_Click(object sender, EventArgs e)
        {
            if (_isCompanyMode)
            {
                var newCompany = new Company
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "New Company",
                    Code = "NEW",
                    IsActive = true,
                    QuotaLimit = 1000,
                    IsNew = true,
                    IsDirty = true
                };
                _companies.Add(newCompany);
                RefreshMasterGrid();
                if (dgvMaster.Rows.Count > 0)
                    dgvMaster.CurrentCell = dgvMaster.Rows[_companies.Count - 1].Cells[1];
            }
            else
            {
                var newUser = new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "new@user.com",
                    Name = "New User",
                    Role = "cs",
                    IsActive = true,
                    IsNew = true,
                    IsDirty = true
                };
                _users.Add(newUser);
                RefreshMasterGrid();
                if (dgvMaster.Rows.Count > 0)
                    dgvMaster.CurrentCell = dgvMaster.Rows[_users.Count - 1].Cells[1];
            }
        }

        private void BtnMasterSave_Click(object sender, EventArgs e)
        {
            if (_isCompanyMode)
                SaveCompanies();
            else
                SaveUsers();
        }

        private void SaveCompanies()
        {
            foreach (var c in _companies.Where(c => c.IsDirty || c.IsNew || c.IsDeleted))
            {
                if (c.IsNew)
                    ApiClient.Instance.Post<Company>("/api/v1/companies", c);
                else if (c.IsDeleted)
                    ApiClient.Instance.Delete<object>($"/api/v1/companies/{c.Id}");
                else if (c.IsDirty)
                    ApiClient.Instance.Put<Company>($"/api/v1/companies/{c.Id}", c);
            }
            LoadCompanies();
        }

        private void SaveUsers()
        {
            foreach (var u in _users.Where(u => u.IsDirty || u.IsNew || u.IsDeleted))
            {
                if (u.IsNew)
                    ApiClient.Instance.Post<User>("/api/v1/users", u);
                else if (u.IsDeleted)
                    ApiClient.Instance.Delete<object>($"/api/v1/users/{u.Id}");
                else if (u.IsDirty)
                    ApiClient.Instance.Put<User>($"/api/v1/users/{u.Id}", u);
            }
            LoadUsers();
        }

        private void BtnServiceRefresh_Click(object sender, EventArgs e)
        {
            LoadServiceData();
        }

        private void BtnServiceSync_Click(object sender, EventArgs e)
        {
            var result = ApiClient.Instance.Post<object>("/api/v1/phone-numbers/sync", null);
            if (result.Success)
                MessageBox.Show("Sync completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sync failed: " + result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadServiceData();
        }

        public void SelectMasterTab(string type)
        {
            tabControl1.SelectedTab = tabMaster;
            if (type == "Company")
                cboMasterType.SelectedIndex = 0;
            else if (type == "User")
                cboMasterType.SelectedIndex = 1;
        }

        private void RefreshMasterGrid()
        {
            dgvMaster.DataSource = null;
            dgvMaster.DataSource = _isCompanyMode ? (object)_companies : _users;
            UpdateMasterRowColors();
        }
    }
}
