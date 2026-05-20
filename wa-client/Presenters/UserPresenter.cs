using System;
using System.Collections.Generic;
using wa_client.Models;
using wa_client.Services;
using wa_client.Views.Interfaces;

namespace wa_client.Presenters
{
    public class UserPresenter
    {
        private readonly IUserView _view;
        private readonly ApiClient _apiClient;

        public UserPresenter(IUserView view)
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
            var response = _apiClient.Get<List<User>>("/api/v1/users");
            if (response.Success && response.Data != null)
            {
                foreach (var u in response.Data)
                {
                    u.IsDirty = false;
                    u.IsNew = false;
                    u.IsDeleted = false;
                }
                _view.Users = response.Data;
            }
            else
            {
                _view.ErrorMessage = response.ErrorMessage ?? "Failed to load users";
            }
        }

        private void SaveChanges()
        {
            if (_view.Users == null) return;

            foreach (var user in _view.Users)
            {
                if (user.IsDeleted)
                {
                    _apiClient.Delete<object>($"/api/v1/users/{user.Id}");
                }
                else if (user.IsNew)
                {
                    _apiClient.Post<User>("/api/v1/users", new
                    {
                        company_id = user.CompanyId,
                        email = user.Email,
                        name = user.Name,
                        role = user.Role,
                        is_active = user.IsActive
                    });
                }
                else if (user.IsDirty)
                {
                    _apiClient.Put<User>($"/api/v1/users/{user.Id}", user);
                }
            }

            LoadData();
        }
    }
}