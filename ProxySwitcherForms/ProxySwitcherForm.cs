using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using ProxySwitcher;
using ProxySwitcherForms.Properties;

namespace ProxySwitcherForms
{
    public partial class ProxySwitcherForm : Form
    {
        private ProfileModel model = new ProfileModel();
        private ProxyController ctrl = new ProxyController();

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
        }

        private void Set_Click(object sender, EventArgs e)
        {
            Profile selected = listBox1.SelectedItem as Profile;
            ctrl.SetProxy(selected.Proxy);
        }

        private void Tray_Click(object sender, EventArgs e)
        {
            //notifyIcon.ShowBalloonTip(3000);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
            Profile profile = profileForm.GetProfile();
            model.AddProfile(profile);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(listBox1.SelectedItem as Profile);
            profileForm.ShowDialog();
            listBox1.Refresh();
            RefreshListBox();
            // todo changed?
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Profile selected = listBox1.SelectedItem as Profile;
            model.RemoveProfile(selected);
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
            btnEnabled.Text = label;
            toolStripMenuItemEnabled.Text = label;
        }

        private void RefreshListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = model.Proxies;
            listBox1.DisplayMember = "Title";
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






    }
}
