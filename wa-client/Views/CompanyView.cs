using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Presenters;
using wa_client.Views.Interfaces;

namespace wa_client.Views
{
    public partial class CompanyView : UserControl, ICompanyView
    {
        private CompanyPresenter _presenter;
        private List<Company> _companies = new List<Company>();

        public List<Company> Companies
        {
            get => _companies;
            set
            {
                _companies = value;
                RefreshDgv();
            }
        }

        public string ErrorMessage
        {
            set => MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public event EventHandler LoadDataRequested;
        public event EventHandler SaveRequested;

        public void LoadData()
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }

        public CompanyView()
        {
            InitializeComponent();
            _presenter = new CompanyPresenter(this);
        }

        private void RefreshDgv()
        {
            dgCompany.DataSource = null;
            dgCompany.DataSource = _companies;
            UpdateRowColors();
        }

        private void UpdateRowColors()
        {
            for (int i = 0; i < dgCompany.Rows.Count; i++)
            {
                var company = dgCompany.Rows[i].DataBoundItem as Company;
                if (company != null)
                {
                    if (company.IsDeleted)
                        dgCompany.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    else if (company.IsDirty)
                        dgCompany.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgCompany.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgCompany_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var company = dgCompany.Rows[e.RowIndex].DataBoundItem as Company;
                if (company != null && !company.IsNew)
                {
                    company.IsDirty = true;
                    UpdateRowColors();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
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
            RefreshDgv();
            dgCompany.CurrentCell = dgCompany.Rows[_companies.Count - 1].Cells[1];
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgCompany.CurrentRow != null)
            {
                var company = dgCompany.CurrentRow.DataBoundItem as Company;
                if (company != null)
                {
                    company.IsDeleted = !company.IsDeleted;
                    UpdateRowColors();
                }
            }
        }
    }
}