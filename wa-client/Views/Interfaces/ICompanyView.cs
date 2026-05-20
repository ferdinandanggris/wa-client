using System;
using System.Collections.Generic;
using wa_client.Models;

namespace wa_client.Views.Interfaces
{
    public interface ICompanyView
    {
        List<Company> Companies { get; set; }
        string ErrorMessage { set; }
        event EventHandler LoadDataRequested;
        event EventHandler SaveRequested;
    }
}