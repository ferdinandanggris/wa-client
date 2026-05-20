using System.Windows.Forms;

namespace wa_client.Views
{
    public partial class AnalyticsView : UserControl
    {
        public AnalyticsView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            lblAnalytics.Text = "Analytics - Coming Soon";
            // TODO: Load analytics data from billing/pricing APIs
        }
    }
}