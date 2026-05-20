using System;
using System.Collections.Generic;
using wa_client.Models;
using wa_client.Services;
using wa_client.Views.Interfaces;

namespace wa_client.Presenters
{
    public class PhoneNumberPresenter
    {
        private readonly IPhoneNumberView _view;
        private readonly ApiClient _apiClient;

        public PhoneNumberPresenter(IPhoneNumberView view)
        {
            _view = view;
            _apiClient = ApiClient.Instance;

            _view.LoadDataRequested += OnLoadDataRequested;
            _view.SaveRequested += OnSaveRequested;

            LoadData();
        }

        private void OnLoadDataRequested(object sender, EventArgs e)
        {
            LoadData();
        }

        private void OnSaveRequested(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void LoadData()
        {
            var response = _apiClient.Get<List<PhoneNumber>>("/api/v1/phone-numbers");
            if (response.Success && response.Data != null)
            {
                foreach (var p in response.Data)
                {
                    p.IsDirty = false;
                    p.IsNew = false;
                    p.IsDeleted = false;
                }
                _view.PhoneNumbers = response.Data;
            }
            else
            {
                _view.ErrorMessage = response.ErrorMessage ?? "Failed to load phone numbers";
            }
        }

        private void SaveChanges()
        {
            if (_view.PhoneNumbers == null) return;

            foreach (var phone in _view.PhoneNumbers)
            {
                if (phone.IsDirty && !phone.IsNew)
                {
                    _apiClient.Put<PhoneNumber>($"/api/v1/phone-numbers/{phone.Id}", phone);
                }
            }

            LoadData();
        }
    }
}