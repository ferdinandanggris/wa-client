using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using wa_client.Models;
using wa_client.Services;
using wa_client.Views.Pages;

namespace wa_client.Forms
{
    public partial class MainForm : Form
    {
        private UserControl currentView;
        private TreeNode phoneNode;
        private bool sidebarExpanded = true;
        private const int SidebarExpandedWidth = 250;
        private const int SidebarCollapsedWidth = 50;

        public MainForm()
        {
            InitializeComponent();
            
            splitContainer.Width = SidebarExpandedWidth;
            
            InitializeTreeView();
            LoadInitialView();
            InitializeClock();
        }

        private void InitializeClock()
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void InitializeTreeView()
        {
            phoneNode = new TreeNode("Phone Number");
            phoneNode.Tag = "phone";

            LoadPhoneNumbersToTree();

            tvMenu.Nodes.Add(phoneNode);

            phoneNode.Expand();
        }

        private void LoadPhoneNumbersToTree()
        {
            phoneNode.Nodes.Clear();

            var response = ApiClient.Instance.Get<PhoneNumberListResponse>("/api/v1/phone-numbers");
            if (response.Success && response.Data != null)
            {
                foreach (var phone in response.Data)
                {
                    string displayText = phone.PhoneNumberVal + " " + (phone.IsActive ? "●" : "○");
                    TreeNode nodePhone = new TreeNode(displayText);
                    nodePhone.Tag = phone;
                    nodePhone.ImageIndex = 3;
                    nodePhone.SelectedImageIndex = 3;
                    phoneNode.Nodes.Add(nodePhone);
                }
            }
        }

        private void LoadInitialView()
        {
            ShowView("main");
            SetStatus("Ready");
        }

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tvMenu.SelectedNode = e.Node;

                if (e.Node.Level == 0)
                {
                    if (e.Node.IsExpanded)
                        e.Node.Collapse();
                    else
                        e.Node.Expand();
                }

                if (e.Node.Level == 0 && e.Node.Tag != null)
                {
                    string tag = e.Node.Tag.ToString();
                    if (tag != "phone")
                    {
                        ShowView(tag);
                    }
                }
                else if (e.Node.Level == 1 && e.Node.Parent.Tag?.ToString() == "phone")
                {
                    ShowView("phone");
                }
            }
        }

        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 1 && e.Node.Parent.Tag?.ToString() == "phone")
            {
                var phone = e.Node.Tag as PhoneNumber;
                if (phone != null)
                {
                    ShowPhoneDetail(phone);
                }
            }
            else if (e.Node.Level == 0 && e.Node.Tag?.ToString() != "phone")
            {
                string tag = e.Node.Tag?.ToString();
                ShowView(tag);
            }
        }

        private void ShowPhoneDetail(PhoneNumber phone)
        {
            if (currentView != null)
            {
                panelContent.Controls.Remove(currentView);
                currentView.Dispose();
            }

            var detailView = new PhoneDetailView(phone);
            detailView.Dock = DockStyle.Fill;
            panelContent.Controls.Add(detailView);
            currentView = detailView;
            SetStatus("Viewing phone detail");
        }

        private void tvMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = tvMenu.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    tvMenu.SelectedNode = node;
                    ShowContextMenu(node, e.Location);
                }
            }
        }

        private void ShowContextMenu(TreeNode node, Point location)
        {
            ContextMenuStrip cms = new ContextMenuStrip();

            if (node.Level == 0)
            {
                switch (node.Tag?.ToString())
                {
                    case "phone":
                        cms.Items.Add("Sync from Meta", null, (s, e) => SyncPhoneNumbers());
                        cms.Items.Add("Refresh", null, (s, e) => RefreshPhoneNumbers());
                        break;
                }
            }
            else if (node.Level == 1)
            {
                if (node.Parent.Tag?.ToString() == "phone")
                {
                    var phone = node.Tag as PhoneNumber;
                    if (phone != null)
                    {
                        cms.Items.Add("View Detail", null, (s, e) => ShowPhoneDetail(phone));
                        cms.Items.Add("Edit", null, (s, e) => MessageBox.Show($"Edit: {phone.PhoneNumberVal}"));
                        cms.Items.Add(new ToolStripSeparator());
                        cms.Items.Add("Assign to Company", null, (s, e) => MessageBox.Show($"Assign: {phone.PhoneNumberVal}"));
                        cms.Items.Add("Update Profile", null, (s, e) => MessageBox.Show($"Profile: {phone.PhoneNumberVal}"));
                    }
                }
            }

            if (cms.Items.Count > 0)
            {
                cms.Show(tvMenu, location);
            }
        }

        private void ShowView(string viewName)
        {
            SetStatus("Loading " + viewName + "...");

            if (currentView != null)
            {
                panelContent.Controls.Remove(currentView);
                currentView.Dispose();
            }

            if (viewName == "main" || viewName == "phone")
            {
                currentView = new MainPageView();
                if (viewName == "phone")
                {
                    var mainPage = (MainPageView)currentView;
                    var tab = mainPage.Controls.OfType<TabControl>().FirstOrDefault();
                    if (tab != null && tab.TabPages.Count >= 4)
                        tab.SelectedTab = tab.TabPages[3];
                }
            }
            else
            {
                currentView = new MainPageView();
            }

            if (currentView != null)
            {
                currentView.Dock = DockStyle.Fill;
                panelContent.Controls.Add(currentView);
            }
            SetStatus("Ready");
        }

        private void SyncPhoneNumbers()
        {
            SetStatus("Syncing phone numbers...");
            MessageBox.Show("Syncing phone numbers from Meta...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus("Ready");
        }

        private void RefreshPhoneNumbers()
        {
            SetStatus("Refreshing phone numbers...");
            LoadPhoneNumbersToTree();
            phoneNode.Expand();
            MessageBox.Show("Phone numbers refreshed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetStatus("Ready");
        }

        private void SetStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void btnCollapseLeft_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
        }

        private void btnCollapseRight_Click(object sender, EventArgs e)
        {
            if (!sidebarExpanded)
            {
                ExpandSidebar();
            }
            else
            {
                CollapseSidebar();
            }
        }

        private void CollapseSidebar()
        {
            if (sidebarExpanded)
            {
                splitContainer.Width = SidebarCollapsedWidth;
                panelSidebarTop.Visible = false;
                tvMenu.Visible = false;
                sidebarExpanded = false;
            }
        }

        private void ExpandSidebar()
        {
            if (!sidebarExpanded)
            {
                splitContainer.Width = SidebarExpandedWidth;
                panelSidebarTop.Visible = true;
                tvMenu.Visible = true;
                sidebarExpanded = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuthService.Instance.Logout();
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5 && currentView is MainPageView mainPage)
            {
                mainPage.LoadData();
                return true;
            }
            if (keyData == Keys.F5 && currentView is DashboardView db)
            {
                db.LoadData();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    public class PhoneNumberListResponse : List<PhoneNumber> { }
}