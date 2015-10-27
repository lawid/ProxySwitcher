using ProxySwitcher.Triggers;

namespace ProxySwitcherForms
{
    partial class TriggerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerForm));
            this.checkBoxIsWiFiTrigger = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAddressTrigger = new System.Windows.Forms.CheckBox();
            this.labelConditionNote = new System.Windows.Forms.Label();
            this.textBoxWiFiSsid = new System.Windows.Forms.TextBox();
            this.labelWiFiExample = new System.Windows.Forms.Label();
            this.textBoxAddressMask = new System.Windows.Forms.TextBox();
            this.labelExampleAddressMask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxIsWiFiTrigger
            // 
            this.checkBoxIsWiFiTrigger.AutoSize = true;
            this.checkBoxIsWiFiTrigger.Location = new System.Drawing.Point(12, 53);
            this.checkBoxIsWiFiTrigger.Name = "checkBoxIsWiFiTrigger";
            this.checkBoxIsWiFiTrigger.Size = new System.Drawing.Size(83, 17);
            this.checkBoxIsWiFiTrigger.TabIndex = 0;
            this.checkBoxIsWiFiTrigger.Text = "WiFi Trigger";
            this.checkBoxIsWiFiTrigger.UseVisualStyleBackColor = true;
            this.checkBoxIsWiFiTrigger.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // checkBoxIsAddressTrigger
            // 
            this.checkBoxIsAddressTrigger.AutoSize = true;
            this.checkBoxIsAddressTrigger.Location = new System.Drawing.Point(12, 95);
            this.checkBoxIsAddressTrigger.Name = "checkBoxIsAddressTrigger";
            this.checkBoxIsAddressTrigger.Size = new System.Drawing.Size(100, 17);
            this.checkBoxIsAddressTrigger.TabIndex = 1;
            this.checkBoxIsAddressTrigger.Text = "Address Trigger";
            this.checkBoxIsAddressTrigger.UseVisualStyleBackColor = true;
            this.checkBoxIsAddressTrigger.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // labelConditionNote
            // 
            this.labelConditionNote.AutoSize = true;
            this.labelConditionNote.Location = new System.Drawing.Point(12, 140);
            this.labelConditionNote.Name = "labelConditionNote";
            this.labelConditionNote.Size = new System.Drawing.Size(318, 13);
            this.labelConditionNote.TabIndex = 2;
            this.labelConditionNote.Text = "checking both will require a match for both wifi and address match";
            // 
            // textBoxWiFiSsid
            // 
            this.textBoxWiFiSsid.Enabled = false;
            this.textBoxWiFiSsid.Location = new System.Drawing.Point(101, 50);
            this.textBoxWiFiSsid.Name = "textBoxWiFiSsid";
            this.textBoxWiFiSsid.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiFiSsid.TabIndex = 3;
            // 
            // labelWiFiExample
            // 
            this.labelWiFiExample.AutoSize = true;
            this.labelWiFiExample.Location = new System.Drawing.Point(216, 54);
            this.labelWiFiExample.Name = "labelWiFiExample";
            this.labelWiFiExample.Size = new System.Drawing.Size(113, 13);
            this.labelWiFiExample.TabIndex = 4;
            this.labelWiFiExample.Text = "Example: MyHomeWifi";
            // 
            // textBoxAddressMask
            // 
            this.textBoxAddressMask.Enabled = false;
            this.textBoxAddressMask.Location = new System.Drawing.Point(118, 93);
            this.textBoxAddressMask.Name = "textBoxAddressMask";
            this.textBoxAddressMask.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddressMask.TabIndex = 5;
            // 
            // labelExampleAddressMask
            // 
            this.labelExampleAddressMask.AutoSize = true;
            this.labelExampleAddressMask.Location = new System.Drawing.Point(224, 96);
            this.labelExampleAddressMask.Name = "labelExampleAddressMask";
            this.labelExampleAddressMask.Size = new System.Drawing.Size(127, 13);
            this.labelExampleAddressMask.TabIndex = 6;
            this.labelExampleAddressMask.Text = "Example: 192.168.0.0/24";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(66, 17);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 8;
            this.textBoxTitle.Text = "New Trigger";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(257, 174);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(338, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 206);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExampleAddressMask);
            this.Controls.Add(this.textBoxAddressMask);
            this.Controls.Add(this.labelWiFiExample);
            this.Controls.Add(this.textBoxWiFiSsid);
            this.Controls.Add(this.labelConditionNote);
            this.Controls.Add(this.checkBoxIsAddressTrigger);
            this.Controls.Add(this.checkBoxIsWiFiTrigger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TriggerForm";
            this.Text = "TriggerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsWiFiTrigger;
        private System.Windows.Forms.CheckBox checkBoxIsAddressTrigger;
        private System.Windows.Forms.Label labelConditionNote;
        private System.Windows.Forms.TextBox textBoxWiFiSsid;
        private System.Windows.Forms.Label labelWiFiExample;
        private System.Windows.Forms.TextBox textBoxAddressMask;
        private System.Windows.Forms.Label labelExampleAddressMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
       
    }
}