using System;
using System.Collections.Generic;
using wa_client.Models;

namespace wa_client.Views.Interfaces
{
    public interface IUserView
    {
        List<User> Users { get; set; }
        string ErrorMessage { set; }
        event EventHandler LoadDataRequested;
        event EventHandler SaveRequested;
    }
}