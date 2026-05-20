using System;
using System.Collections.Generic;
using wa_client.Models;
using wa_client.Services;
using wa_client.Views.Interfaces;

namespace wa_client.Presenters
{
    public class CompanyPresenter
    {
        private readonly ICompanyView _view;
        private readonly ApiClient _apiClient;

        public CompanyPresenter(ICompanyView view)
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
            var response = _apiClient.Get<List<Company>>("/api/v1/companies");
            if (response.Success && response.Data != null)
            {
                foreach (var c in response.Data)
                {
                    c.IsDirty = false;
                    c.IsNew = false;
                    c.IsDeleted = false;
                }
                _view.Companies = response.Data;
            }
            else
            {
                _view.ErrorMessage = response.ErrorMessage ?? "Failed to load companies";
            }
        }

        private void SaveChanges()
        {
            if (_view.Companies == null) return;

            foreach (var company in _view.Companies)
            {
                if (company.IsDeleted)
                {
                    _apiClient.Delete<object>($"/api/v1/companies/{company.Id}");
                }
                else if (company.IsNew)
                {
                    _apiClient.Post<Company>("/api/v1/companies", new
                    {
                        name = company.Name,
                        code = company.Code,
                        phone_number = company.PhoneNumber?.String,
                        address = company.Address?.String,
                        quota_limit = company.QuotaLimit,
                        is_active = company.IsActive
                    });
                }
                else if (company.IsDirty)
                {
                    _apiClient.Put<Company>($"/api/v1/companies/{company.Id}", company);
                }
            }

            LoadData();
        }
    }
}