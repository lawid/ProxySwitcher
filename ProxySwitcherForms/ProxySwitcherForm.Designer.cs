namespace ProxySwitcherForms
{
    partial class ProxySwitcherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxySwitcherForm));
            this.profileSetBtn = new System.Windows.Forms.Button();
            this.proxyEnableBtn = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemEnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.triggersListBox = new System.Windows.Forms.ListBox();
            this.triggersGroupBox = new System.Windows.Forms.GroupBox();
            this.triggersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.triggersAddBtn = new System.Windows.Forms.Button();
            this.triggersEditBtn = new System.Windows.Forms.Button();
            this.triggersRemoveBtn = new System.Windows.Forms.Button();
            this.groupBoxProfiles = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelProfiles = new System.Windows.Forms.TableLayoutPanel();
            this.profilesListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.profileAddBtn = new System.Windows.Forms.Button();
            this.profileEditBtn = new System.Windows.Forms.Button();
            this.profileRemoveBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.startupButton = new System.Windows.Forms.Button();
            this.trayRightClickMenu.SuspendLayout();
            this.triggersGroupBox.SuspendLayout();
            this.triggersTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxProfiles.SuspendLayout();
            this.tableLayoutPanelProfiles.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileSetBtn
            // 
            this.profileSetBtn.Location = new System.Drawing.Point(3, 77);
            this.profileSetBtn.Name = "profileSetBtn";
            this.profileSetBtn.Size = new System.Drawing.Size(75, 23);
            this.profileSetBtn.TabIndex = 1;
            this.profileSetBtn.Text = "Set";
            this.profileSetBtn.UseVisualStyleBackColor = true;
            this.profileSetBtn.Click += new System.EventHandler(this.Set_Click);
            // 
            // proxyEnableBtn
            // 
            this.proxyEnableBtn.Location = new System.Drawing.Point(3, 106);
            this.proxyEnableBtn.Name = "proxyEnableBtn";
            this.proxyEnableBtn.Size = new System.Drawing.Size(75, 23);
            this.proxyEnableBtn.TabIndex = 2;
            this.proxyEnableBtn.Text = "Enable/Disable";
            this.proxyEnableBtn.UseVisualStyleBackColor = true;
            this.proxyEnableBtn.Click += new System.EventHandler(this.ToggleEnabled);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "Hello";
            this.trayIcon.BalloonTipTitle = "Hehehe";
            this.trayIcon.ContextMenuStrip = this.trayRightClickMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "ProxySwitcher";
            this.trayIcon.Visible = true;
            this.trayIcon.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayRightClickMenu
            // 
            this.trayRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnabled,
            this.toolStripSeparator2,
            this.toolStripMenuItemExit});
            this.trayRightClickMenu.Name = "contextMenuStrip1";
            this.trayRightClickMenu.Size = new System.Drawing.Size(153, 76);
            this.trayRightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.trayRightClickMenu_Opening);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItemEnabled
            // 
            this.toolStripMenuItemEnabled.Name = "toolStripMenuItemEnabled";
            this.toolStripMenuItemEnabled.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemEnabled.Text = "Enable/Disable";
            this.toolStripMenuItemEnabled.Click += new System.EventHandler(this.ToggleEnabled);
            // 
            // triggersListBox
            // 
            this.triggersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggersListBox.FormattingEnabled = true;
            this.triggersListBox.Location = new System.Drawing.Point(3, 3);
            this.triggersListBox.Name = "triggersListBox";
            this.triggersTableLayoutPanel.SetRowSpan(this.triggersListBox, 2);
            this.triggersListBox.Size = new System.Drawing.Size(107, 269);
            this.triggersListBox.TabIndex = 9;
            // 
            // triggersGroupBox
            // 
            this.triggersGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.triggersGroupBox.Controls.Add(this.triggersTableLayoutPanel);
            this.triggersGroupBox.Location = new System.Drawing.Point(222, 27);
            this.triggersGroupBox.Name = "triggersGroupBox";
            this.triggersGroupBox.Size = new System.Drawing.Size(209, 294);
            this.triggersGroupBox.TabIndex = 10;
            this.triggersGroupBox.TabStop = false;
            this.triggersGroupBox.Text = "Triggers";
            // 
            // triggersTableLayoutPanel
            // 
            this.triggersTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.triggersTableLayoutPanel.ColumnCount = 2;
            this.triggersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.triggersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.triggersTableLayoutPanel.Controls.Add(this.triggersListBox, 0, 0);
            this.triggersTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.triggersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggersTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.triggersTableLayoutPanel.Name = "triggersTableLayoutPanel";
            this.triggersTableLayoutPanel.RowCount = 2;
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.triggersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.triggersTableLayoutPanel.Size = new System.Drawing.Size(203, 275);
            this.triggersTableLayoutPanel.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.triggersAddBtn);
            this.flowLayoutPanel1.Controls.Add(this.triggersEditBtn);
            this.flowLayoutPanel1.Controls.Add(this.triggersRemoveBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 131);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // triggersAddBtn
            // 
            this.triggersAddBtn.Location = new System.Drawing.Point(3, 3);
            this.triggersAddBtn.Name = "triggersAddBtn";
            this.triggersAddBtn.Size = new System.Drawing.Size(75, 23);
            this.triggersAddBtn.TabIndex = 0;
            this.triggersAddBtn.Text = "Add";
            this.triggersAddBtn.UseVisualStyleBackColor = true;
            this.triggersAddBtn.Click += new System.EventHandler(this.triggersAddBtn_Click);
            // 
            // triggersEditBtn
            // 
            this.triggersEditBtn.Location = new System.Drawing.Point(3, 32);
            this.triggersEditBtn.Name = "triggersEditBtn";
            this.triggersEditBtn.Size = new System.Drawing.Size(75, 23);
            this.triggersEditBtn.TabIndex = 1;
            this.triggersEditBtn.Text = "Edit";
            this.triggersEditBtn.UseVisualStyleBackColor = true;
            this.triggersEditBtn.Click += new System.EventHandler(this.triggersEditBtn_Click);
            // 
            // triggersRemoveBtn
            // 
            this.triggersRemoveBtn.Location = new System.Drawing.Point(3, 61);
            this.triggersRemoveBtn.Name = "triggersRemoveBtn";
            this.triggersRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.triggersRemoveBtn.TabIndex = 2;
            this.triggersRemoveBtn.Text = "Remove";
            this.triggersRemoveBtn.UseVisualStyleBackColor = true;
            this.triggersRemoveBtn.Click += new System.EventHandler(this.triggersRemoveBtn_Click);
            // 
            // groupBoxProfiles
            // 
            this.groupBoxProfiles.Controls.Add(this.tableLayoutPanelProfiles);
            this.groupBoxProfiles.Location = new System.Drawing.Point(12, 27);
            this.groupBoxProfiles.Name = "groupBoxProfiles";
            this.groupBoxProfiles.Size = new System.Drawing.Size(204, 294);
            this.groupBoxProfiles.TabIndex = 12;
            this.groupBoxProfiles.TabStop = false;
            this.groupBoxProfiles.Text = "Profiles";
            // 
            // tableLayoutPanelProfiles
            // 
            this.tableLayoutPanelProfiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelProfiles.ColumnCount = 2;
            this.tableLayoutPanelProfiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProfiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelProfiles.Controls.Add(this.profilesListBox, 0, 0);
            this.tableLayoutPanelProfiles.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanelProfiles.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanelProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProfiles.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelProfiles.Name = "tableLayoutPanelProfiles";
            this.tableLayoutPanelProfiles.RowCount = 2;
            this.tableLayoutPanelProfiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProfiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProfiles.Size = new System.Drawing.Size(198, 275);
            this.tableLayoutPanelProfiles.TabIndex = 1;
            // 
            // profilesListBox
            // 
            this.profilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilesListBox.FormattingEnabled = true;
            this.profilesListBox.Location = new System.Drawing.Point(3, 3);
            this.profilesListBox.Name = "profilesListBox";
            this.tableLayoutPanelProfiles.SetRowSpan(this.profilesListBox, 2);
            this.profilesListBox.Size = new System.Drawing.Size(102, 269);
            this.profilesListBox.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.profileAddBtn);
            this.flowLayoutPanel2.Controls.Add(this.profileEditBtn);
            this.flowLayoutPanel2.Controls.Add(this.profileRemoveBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(111, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(84, 131);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // profileAddBtn
            // 
            this.profileAddBtn.Location = new System.Drawing.Point(3, 3);
            this.profileAddBtn.Name = "profileAddBtn";
            this.profileAddBtn.Size = new System.Drawing.Size(75, 23);
            this.profileAddBtn.TabIndex = 6;
            this.profileAddBtn.Text = "Add";
            this.profileAddBtn.UseVisualStyleBackColor = true;
            this.profileAddBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // profileEditBtn
            // 
            this.profileEditBtn.Location = new System.Drawing.Point(3, 32);
            this.profileEditBtn.Name = "profileEditBtn";
            this.profileEditBtn.Size = new System.Drawing.Size(75, 23);
            this.profileEditBtn.TabIndex = 7;
            this.profileEditBtn.Text = "Edit";
            this.profileEditBtn.UseVisualStyleBackColor = true;
            this.profileEditBtn.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // profileRemoveBtn
            // 
            this.profileRemoveBtn.Location = new System.Drawing.Point(3, 61);
            this.profileRemoveBtn.Name = "profileRemoveBtn";
            this.profileRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.profileRemoveBtn.TabIndex = 8;
            this.profileRemoveBtn.Text = "Remove";
            this.profileRemoveBtn.UseVisualStyleBackColor = true;
            this.profileRemoveBtn.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.proxyEnableBtn);
            this.flowLayoutPanel3.Controls.Add(this.profileSetBtn);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(111, 140);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(84, 132);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 331);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(574, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel4);
            this.groupBox1.Location = new System.Drawing.Point(437, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 293);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.startupButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(123, 274);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // startupButton
            // 
            this.startupButton.Location = new System.Drawing.Point(3, 3);
            this.startupButton.Name = "startupButton";
            this.startupButton.Size = new System.Drawing.Size(117, 23);
            this.startupButton.TabIndex = 0;
            this.startupButton.Text = "Register startup";
            this.startupButton.UseVisualStyleBackColor = true;
            this.startupButton.Click += new System.EventHandler(this.startupButton_Click);
            // 
            // ProxySwitcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxProfiles);
            this.Controls.Add(this.triggersGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProxySwitcherForm";
            this.ShowInTaskbar = false;
            this.Text = "ProxySwitcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProxySwitcherForm_FormClosing);
            this.Load += new System.EventHandler(this.ProxySwitcherForm_Load);
            this.trayRightClickMenu.ResumeLayout(false);
            this.triggersGroupBox.ResumeLayout(false);
            this.triggersTableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxProfiles.ResumeLayout(false);
            this.tableLayoutPanelProfiles.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button profileSetBtn;
        private System.Windows.Forms.Button proxyEnableBtn;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnabled;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListBox triggersListBox;
        private System.Windows.Forms.TableLayoutPanel triggersTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button triggersAddBtn;
        private System.Windows.Forms.Button triggersEditBtn;
        private System.Windows.Forms.Button triggersRemoveBtn;
        private System.Windows.Forms.GroupBox triggersGroupBox;
        private System.Windows.Forms.GroupBox groupBoxProfiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProfiles;
        private System.Windows.Forms.ListBox profilesListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button profileAddBtn;
        private System.Windows.Forms.Button profileEditBtn;
        private System.Windows.Forms.Button profileRemoveBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button startupButton;
    }
}

