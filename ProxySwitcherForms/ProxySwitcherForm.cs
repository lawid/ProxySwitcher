﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProxySwitcher;
using ProxySwitcherForms.Properties;
using ProxySwitcher.Triggers;

namespace ProxySwitcherForms
{
    public partial class ProxySwitcherForm : Form
    {
        private ProfileModel model = ProfileModel.Instance;
        private ProxyController ctrl = new ProxyController();
        private TriggerListener triggers = new TriggerListener();

        public ProxySwitcherForm()
        {
            InitializeComponent();

            model.Proxies.ListChanged += ProxiesOnListChanged;
            RefreshListBox();
            RefreshTrayMenu();
            RefreshEnabled();

        }

        private void ProxiesOnListChanged(object sender, ListChangedEventArgs listChangedEventArgs)
        {
            RefreshTrayMenu();
        }

        private void RefreshTrayMenu()
        {

        }


        private void Read_Click(object sender, EventArgs e)
        {
            ctrl.PrintCurrentSettings();
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(model.Proxies.First()));
        }

        private void Set_Click(object sender, EventArgs e)
        {
            Profile selected = profilesListBox.SelectedItem as Profile;
            ctrl.SetProxy(selected.Proxy);
        }

        private void Tray_Click(object sender, EventArgs e)
        {
            //notifyIcon.ShowBalloonTip(3000);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            DialogResult addStatus = profileForm.ShowDialog();
            
            if (addStatus == DialogResult.OK)
            {
                Profile profile = profileForm.GetProfile();
                model.Proxies.Add(profile);
                //RefreshListBox();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(profilesListBox.SelectedItem as Profile);
            profileForm.ShowDialog();
            profilesListBox.Refresh();
            RefreshListBox();
            // todo changed?
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Profile selected = profilesListBox.SelectedItem as Profile;
            model.Proxies.Remove(selected);
        }

        private void btnEnabled_Click(object sender, EventArgs e)
        {
            ToggleEnabled();
        }
        private void toolStripMenuItemEnabled_Click(object sender, EventArgs e)
        {
            ToggleEnabled();
        }

        private void ToggleEnabled()
        {
            ctrl.SetEnabled(!ctrl.IsEnabled());
            RefreshEnabled();
        }

        private void RefreshEnabled()
        {
            string label = (ctrl.IsEnabled()) ? "Disable" : "Enable";
            proxyEnableBtn.Text = label;
            toolStripMenuItemEnabled.Text = label;
        }

        private void RefreshListBox()
        {
            profilesListBox.DataSource = null;
            profilesListBox.DataSource = model.Proxies;
            profilesListBox.DisplayMember = "Title";
        }

        private void ProxySwitcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("saving settings");
            model.SaveProfiles();

            //Settings.Default.
            Settings.Default.Save();
        }


        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            var me = e as MouseEventArgs;
            if (me != null && me.Button == MouseButtons.Left)
            {
                if (this.Visible)
                {
                    this.Hide();
                }
                else
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    Activate();
                }
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enableTriggersToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("check changed to " + enableTriggersToolStripMenuItem.Checked);
        }

        private void triggersAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void triggersEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void triggersRemoveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
