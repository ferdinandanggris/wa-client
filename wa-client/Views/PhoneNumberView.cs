using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Presenters;
using wa_client.Views.Interfaces;

namespace wa_client.Views
{
    public partial class PhoneNumberView : UserControl, IPhoneNumberView
    {
        private PhoneNumberPresenter _presenter;
        private List<PhoneNumber> _phoneNumbers = new List<PhoneNumber>();

        public List<PhoneNumber> PhoneNumbers
        {
            get => _phoneNumbers;
            set
            {
                _phoneNumbers = value;
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

        public PhoneNumberView()
        {
            InitializeComponent();
            _presenter = new PhoneNumberPresenter(this);
        }

        private void RefreshDgv()
        {
            dgPhone.DataSource = null;
            dgPhone.DataSource = _phoneNumbers;
            UpdateRowColors();
        }

        private void UpdateRowColors()
        {
            for (int i = 0; i < dgPhone.Rows.Count; i++)
            {
                var phone = dgPhone.Rows[i].DataBoundItem as PhoneNumber;
                if (phone != null)
                {
                    if (phone.IsDeleted)
                        dgPhone.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    else if (phone.IsDirty)
                        dgPhone.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        dgPhone.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgPhone_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var phone = dgPhone.Rows[e.RowIndex].DataBoundItem as PhoneNumber;
                if (phone != null && !phone.IsNew)
                {
                    phone.IsDirty = true;
                    UpdateRowColors();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var newPhone = new PhoneNumber
            {
                Id = Guid.NewGuid().ToString(),
                PhoneNumberVal = "+628",
                IsActive = true,
                IsNew = true,
                IsDirty = true
            };
            _phoneNumbers.Add(newPhone);
            RefreshDgv();
            dgPhone.CurrentCell = dgPhone.Rows[_phoneNumbers.Count - 1].Cells[1];
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgPhone.CurrentRow != null)
            {
                var phone = dgPhone.CurrentRow.DataBoundItem as PhoneNumber;
                if (phone != null)
                {
                    phone.IsDeleted = !phone.IsDeleted;
                    UpdateRowColors();
                }
            }
        }

        private void dgPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var currentRow = dgPhone.HitTest(e.Y, e.X).RowIndex;
                if (currentRow >= 0)
                {
                    dgPhone.CurrentCell = dgPhone.Rows[currentRow].Cells[1];
                    var phone = dgPhone.Rows[currentRow].DataBoundItem as PhoneNumber;
                    if (phone != null)
                    {
                        ShowContextMenu(phone, e.Location);
                    }
                }
            }
        }

        private void ShowContextMenu(PhoneNumber phone, Point location)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.Add("Edit", null, (s, ev) => MessageBox.Show($"Edit: {phone.PhoneNumberVal}"));
            cms.Items.Add("Delete", null, (s, ev) =>
            {
                phone.IsDeleted = !phone.IsDeleted;
                UpdateRowColors();
            });
            cms.Items.Add(new ToolStripSeparator());
            cms.Items.Add("Assign to Company", null, (s, ev) => MessageBox.Show($"Assign: {phone.PhoneNumberVal}"));
            cms.Items.Add("Update Profile", null, (s, ev) => MessageBox.Show($"Profile: {phone.PhoneNumberVal}"));
            cms.Show(dgPhone, location);
        }
    }
}