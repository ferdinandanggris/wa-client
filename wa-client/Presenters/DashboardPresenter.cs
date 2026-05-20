using System;
using System.Collections.Generic;
using wa_client.Models;
using wa_client.Services;
using wa_client.Views.Interfaces;

namespace wa_client.Presenters
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;
        private readonly ApiClient _apiClient;

        public DashboardPresenter(IDashboardView view)
        {
            _view = view;
            _apiClient = ApiClient.Instance;

            _view.LoadDataRequested += OnLoadDataRequested;

            LoadData();
        }

        private void OnLoadDataRequested(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var companiesResponse = _apiClient.Get<List<Company>>("/api/v1/companies");
            var usersResponse = _apiClient.Get<List<User>>("/api/v1/users");
            var phonesResponse = _apiClient.Get<List<PhoneNumber>>("/api/v1/phone-numbers");

            int totalCompanies = companiesResponse.Success ? companiesResponse.Data?.Count ?? 0 : 0;
            int totalUsers = usersResponse.Success ? usersResponse.Data?.Count ?? 0 : 0;
            int totalPhones = phonesResponse.Success ? phonesResponse.Data?.Count ?? 0 : 0;
            int activePhones = 0;

            if (phonesResponse.Success && phonesResponse.Data != null)
            {
                foreach (var p in phonesResponse.Data)
                {
                    if (p.IsActive) activePhones++;
                }
            }

            _view.TotalCompanies = totalCompanies.ToString();
            _view.TotalUsers = totalUsers.ToString();
            _view.TotalPhoneNumbers = totalPhones.ToString();
            _view.ActivePhoneNumbers = activePhones.ToString();
        }
    }
}