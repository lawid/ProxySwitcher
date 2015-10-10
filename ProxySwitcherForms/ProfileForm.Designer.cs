namespace ProxySwitcherForms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.labelHttp = new System.Windows.Forms.Label();
            this.textBoxHttpAddress = new System.Windows.Forms.TextBox();
            this.labelSecure = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelProxyAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHttpPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSecureAddress = new System.Windows.Forms.TextBox();
            this.textBoxSecurePort = new System.Windows.Forms.TextBox();
            this.labelFtp = new System.Windows.Forms.Label();
            this.textBoxFtpAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFtpPort = new System.Windows.Forms.TextBox();
            this.labelSocks = new System.Windows.Forms.Label();
            this.textBoxSocksAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSocksPort = new System.Windows.Forms.TextBox();
            this.checkBoxUseForAllProtocols = new System.Windows.Forms.CheckBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.btnLdSys = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHttp
            // 
            this.labelHttp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHttp.AutoSize = true;
            this.labelHttp.Location = new System.Drawing.Point(5, 48);
            this.labelHttp.Name = "labelHttp";
            this.labelHttp.Size = new System.Drawing.Size(36, 13);
            this.labelHttp.TabIndex = 0;
            this.labelHttp.Text = "HTTP";
            // 
            // textBoxHttpAddress
            // 
            this.textBoxHttpAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHttpAddress.Location = new System.Drawing.Point(50, 45);
            this.textBoxHttpAddress.Name = "textBoxHttpAddress";
            this.textBoxHttpAddress.Size = new System.Drawing.Size(177, 20);
            this.textBoxHttpAddress.TabIndex = 1;
            // 
            // labelSecure
            // 
            this.labelSecure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSecure.AutoSize = true;
            this.labelSecure.Location = new System.Drawing.Point(3, 97);
            this.labelSecure.Name = "labelSecure";
            this.labelSecure.Size = new System.Drawing.Size(41, 13);
            this.labelSecure.TabIndex = 2;
            this.labelSecure.Text = "Secure";
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(6, 29);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(35, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // labelProxyAddress
            // 
            this.labelProxyAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProxyAddress.AutoSize = true;
            this.labelProxyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProxyAddress.Location = new System.Drawing.Point(50, 29);
            this.labelProxyAddress.Name = "labelProxyAddress";
            this.labelProxyAddress.Size = new System.Drawing.Size(125, 13);
            this.labelProxyAddress.TabIndex = 4;
            this.labelProxyAddress.Text = "Proxy address to use";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // textBoxHttpPort
            // 
            this.textBoxHttpPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHttpPort.Location = new System.Drawing.Point(249, 45);
            this.textBoxHttpPort.Name = "textBoxHttpPort";
            this.textBoxHttpPort.Size = new System.Drawing.Size(177, 20);
            this.textBoxHttpPort.TabIndex = 6;
            // 
            // labelPort
            // 
            this.labelPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(249, 29);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(30, 13);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            // 
            // textBoxSecureAddress
            // 
            this.textBoxSecureAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSecureAddress.Location = new System.Drawing.Point(50, 94);
            this.textBoxSecureAddress.Name = "textBoxSecureAddress";
            this.textBoxSecureAddress.Size = new System.Drawing.Size(177, 20);
            this.textBoxSecureAddress.TabIndex = 9;
            // 
            // textBoxSecurePort
            // 
            this.textBoxSecurePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSecurePort.Location = new System.Drawing.Point(249, 94);
            this.textBoxSecurePort.Name = "textBoxSecurePort";
            this.textBoxSecurePort.Size = new System.Drawing.Size(177, 20);
            this.textBoxSecurePort.TabIndex = 10;
            // 
            // labelFtp
            // 
            this.labelFtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFtp.AutoSize = true;
            this.labelFtp.Location = new System.Drawing.Point(10, 123);
            this.labelFtp.Name = "labelFtp";
            this.labelFtp.Size = new System.Drawing.Size(27, 13);
            this.labelFtp.TabIndex = 11;
            this.labelFtp.Text = "FTP";
            // 
            // textBoxFtpAddress
            // 
            this.textBoxFtpAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFtpAddress.Location = new System.Drawing.Point(50, 120);
            this.textBoxFtpAddress.Name = "textBoxFtpAddress";
            this.textBoxFtpAddress.Size = new System.Drawing.Size(177, 20);
            this.textBoxFtpAddress.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = ":";
            // 
            // textBoxFtpPort
            // 
            this.textBoxFtpPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFtpPort.Location = new System.Drawing.Point(249, 120);
            this.textBoxFtpPort.Name = "textBoxFtpPort";
            this.textBoxFtpPort.Size = new System.Drawing.Size(177, 20);
            this.textBoxFtpPort.TabIndex = 14;
            // 
            // labelSocks
            // 
            this.labelSocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSocks.AutoSize = true;
            this.labelSocks.Location = new System.Drawing.Point(5, 149);
            this.labelSocks.Name = "labelSocks";
            this.labelSocks.Size = new System.Drawing.Size(37, 13);
            this.labelSocks.TabIndex = 15;
            this.labelSocks.Text = "Socks";
            // 
            // textBoxSocksAddress
            // 
            this.textBoxSocksAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSocksAddress.Location = new System.Drawing.Point(50, 146);
            this.textBoxSocksAddress.Name = "textBoxSocksAddress";
            this.textBoxSocksAddress.Size = new System.Drawing.Size(177, 20);
            this.textBoxSocksAddress.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = ":";
            // 
            // textBoxSocksPort
            // 
            this.textBoxSocksPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSocksPort.Location = new System.Drawing.Point(249, 146);
            this.textBoxSocksPort.Name = "textBoxSocksPort";
            this.textBoxSocksPort.Size = new System.Drawing.Size(177, 20);
            this.textBoxSocksPort.TabIndex = 18;
            // 
            // checkBoxUseForAllProtocols
            // 
            this.checkBoxUseForAllProtocols.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUseForAllProtocols.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxUseForAllProtocols, 3);
            this.checkBoxUseForAllProtocols.Location = new System.Drawing.Point(50, 71);
            this.checkBoxUseForAllProtocols.Name = "checkBoxUseForAllProtocols";
            this.checkBoxUseForAllProtocols.Size = new System.Drawing.Size(225, 17);
            this.checkBoxUseForAllProtocols.TabIndex = 21;
            this.checkBoxUseForAllProtocols.Text = "Use the same proxy server for all protocols";
            this.checkBoxUseForAllProtocols.UseVisualStyleBackColor = true;
            this.checkBoxUseForAllProtocols.CheckedChanged += new System.EventHandler(this.checkBoxUseForAllProtocols_CheckedChanged);
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(5, 8);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(36, 13);
            this.lblProfile.TabIndex = 22;
            this.lblProfile.Text = "Profile";
            // 
            // textBoxProfile
            // 
            this.textBoxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProfile.Location = new System.Drawing.Point(50, 3);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(177, 20);
            this.textBoxProfile.TabIndex = 23;
            this.textBoxProfile.Text = "New Profile";
            // 
            // btnLdSys
            // 
            this.btnLdSys.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLdSys.Location = new System.Drawing.Point(298, 3);
            this.btnLdSys.Name = "btnLdSys";
            this.btnLdSys.Size = new System.Drawing.Size(128, 23);
            this.btnLdSys.TabIndex = 24;
            this.btnLdSys.Text = "Load system values";
            this.btnLdSys.UseVisualStyleBackColor = true;
            this.btnLdSys.Click += new System.EventHandler(this.btnLdSys_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblProfile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLdSys, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProfile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSocksPort, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelProxyAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSocksAddress, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSocks, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelHttp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFtpPort, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHttpAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHttpPort, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFtpAddress, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFtp, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSecurePort, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelSecure, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSecureAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUseForAllProtocols, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 206);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.buttonClose);
            this.flowLayoutPanel1.Controls.Add(this.buttonOk);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(252, 172);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 29);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(96, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 19;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.Text = "Edit Profile";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHttp;
        private System.Windows.Forms.TextBox textBoxHttpAddress;
        private System.Windows.Forms.Label labelSecure;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelProxyAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHttpPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSecureAddress;
        private System.Windows.Forms.TextBox textBoxSecurePort;
        private System.Windows.Forms.Label labelFtp;
        private System.Windows.Forms.TextBox textBoxFtpAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFtpPort;
        private System.Windows.Forms.Label labelSocks;
        private System.Windows.Forms.TextBox textBoxSocksAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSocksPort;
        private System.Windows.Forms.CheckBox checkBoxUseForAllProtocols;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.Button btnLdSys;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOk;
    }
}