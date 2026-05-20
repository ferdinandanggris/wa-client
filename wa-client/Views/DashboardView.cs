using System;
using System.Windows.Forms;
using wa_client.Presenters;
using wa_client.Views.Interfaces;

namespace wa_client.Views
{
    public partial class DashboardView : UserControl, IDashboardView
    {
        private DashboardPresenter _presenter;

        public string TotalCompanies
        {
            set => lblTotalCompanies.Text = value;
        }

        public string TotalUsers
        {
            set => lblTotalUsers.Text = value;
        }

        public string TotalPhoneNumbers
        {
            set => lblTotalPhones.Text = value;
        }

        public string ActivePhoneNumbers
        {
            set => lblActivePhones.Text = value;
        }

        public string ErrorMessage
        {
            set => MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public event EventHandler LoadDataRequested;

        public void LoadData()
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }

        public DashboardView()
        {
            InitializeComponent();
            _presenter = new DashboardPresenter(this);
        }
    }
}