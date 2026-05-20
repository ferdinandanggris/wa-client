using System;
using System.Collections.Generic;
using wa_client.Models;

namespace wa_client.Views.Interfaces
{
    public interface IPhoneNumberView
    {
        List<PhoneNumber> PhoneNumbers { get; set; }
        string ErrorMessage { set; }
        event EventHandler LoadDataRequested;
        event EventHandler SaveRequested;
    }
}