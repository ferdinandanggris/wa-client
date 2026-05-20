using System;

namespace wa_client.Views.Interfaces
{
    public interface IDashboardView
    {
        string TotalCompanies { set; }
        string TotalUsers { set; }
        string TotalPhoneNumbers { set; }
        string ActivePhoneNumbers { set; }
        string ErrorMessage { set; }
        event EventHandler LoadDataRequested;
    }
}