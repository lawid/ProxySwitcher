using ProxySwitcher.Triggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcherForms
{
    public partial class TriggerForm : Form
    {
        public Trigger Trigger { get; private set; }

        public TriggerForm()
        {
            InitializeComponent();

        }

        public TriggerForm(Trigger selected) : this()
        {
            Trigger = selected;
            LoadData();
        }

        private void LoadData()
        {
            textBoxTitle.Text = Trigger.Title;
            checkBoxIsWiFiTrigger.Checked = Trigger.IsWiFiTrigger;
            textBoxWiFiSsid.Text = Trigger.WiFiSsid;
            checkBoxIsAddressTrigger.Checked = Trigger.IsAddressTrigger;
            textBoxAddressMask.Text = Trigger.AddressMask;
        }

        private void RetrieveData()
        {
            Trigger.Title = textBoxTitle.Text;
            Trigger.IsWiFiTrigger = checkBoxIsWiFiTrigger.Checked;
            Trigger.WiFiSsid = textBoxWiFiSsid.Text;
            Trigger.IsAddressTrigger = checkBoxIsAddressTrigger.Checked;
            Trigger.AddressMask = textBoxAddressMask.Text;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Trigger == null) Trigger = new Trigger();
            RetrieveData();
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWiFiSsid.Enabled = checkBoxIsWiFiTrigger.Checked;
            textBoxAddressMask.Enabled = checkBoxIsAddressTrigger.Checked;
        }
    }
}
