using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Presenters;
using wa_client.Views.Interfaces;

namespace wa_client.Views
{
    public partial class UserView : UserControl, IUserView
    {
        private UserPresenter _presenter;
        private List<User> _users = new List<User>();

        public List<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                RefreshDgv();
            }
        }

        public string ErrorMessage
        {
            set => MessageBox.Show(value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public event EventHandler LoadDataRequested;
        public event EventHandler SaveRequested;

        public void LoadData()
        {
            LoadDataRequested?.Invoke(this, EventArgs.Empty);
        }

        public UserView()
        {
            InitializeComponent();
            _presenter = new UserPresenter(this);
        }

        private void RefreshDgv()
        {
            dgUser.DataSource = null;
            dgUser.DataSource = _users;
            UpdateRowColors();
        }

        private void UpdateRowColors()
        {
            for (int i = 0; i < dgUser.Rows.Count; i++)
            {
                var user = dgUser.Rows[i].DataBoundItem as User;
                if (user != null)
                {
                    if (user.IsDeleted)
                        dgUser.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    else if (user.IsDirty)
                        dgUser.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgUser.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var user = dgUser.Rows[e.RowIndex].DataBoundItem as User;
                if (user != null && !user.IsNew)
                {
                    user.IsDirty = true;
                    UpdateRowColors();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                Name = "New User",
                Email = "new@user.com",
                Role = "admin",
                IsActive = true,
                IsNew = true,
                IsDirty = true
            };
            _users.Add(newUser);
            RefreshDgv();
            dgUser.CurrentCell = dgUser.Rows[_users.Count - 1].Cells[1];
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgUser.CurrentRow != null)
            {
                var user = dgUser.CurrentRow.DataBoundItem as User;
                if (user != null)
                {
                    user.IsDeleted = !user.IsDeleted;
                    UpdateRowColors();
                }
            }
        }
    }
}