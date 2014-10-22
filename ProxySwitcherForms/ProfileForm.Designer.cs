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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxUseForAllProtocols = new System.Windows.Forms.CheckBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.btnLdSys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHttp
            // 
            this.labelHttp.AutoSize = true;
            this.labelHttp.Location = new System.Drawing.Point(12, 36);
            this.labelHttp.Name = "labelHttp";
            this.labelHttp.Size = new System.Drawing.Size(36, 13);
            this.labelHttp.TabIndex = 0;
            this.labelHttp.Text = "HTTP";
            // 
            // textBoxHttpAddress
            // 
            this.textBoxHttpAddress.Location = new System.Drawing.Point(65, 29);
            this.textBoxHttpAddress.Name = "textBoxHttpAddress";
            this.textBoxHttpAddress.Size = new System.Drawing.Size(142, 20);
            this.textBoxHttpAddress.TabIndex = 1;
            // 
            // labelSecure
            // 
            this.labelSecure.AutoSize = true;
            this.labelSecure.Location = new System.Drawing.Point(14, 90);
            this.labelSecure.Name = "labelSecure";
            this.labelSecure.Size = new System.Drawing.Size(41, 13);
            this.labelSecure.TabIndex = 2;
            this.labelSecure.Text = "Secure";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(17, 13);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // labelProxyAddress
            // 
            this.labelProxyAddress.AutoSize = true;
            this.labelProxyAddress.Location = new System.Drawing.Point(65, 10);
            this.labelProxyAddress.Name = "labelProxyAddress";
            this.labelProxyAddress.Size = new System.Drawing.Size(105, 13);
            this.labelProxyAddress.TabIndex = 4;
            this.labelProxyAddress.Text = "Proxy address to use";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // textBoxHttpPort
            // 
            this.textBoxHttpPort.Location = new System.Drawing.Point(231, 28);
            this.textBoxHttpPort.Name = "textBoxHttpPort";
            this.textBoxHttpPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxHttpPort.TabIndex = 6;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(231, 9);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            // 
            // textBoxSecureAddress
            // 
            this.textBoxSecureAddress.Location = new System.Drawing.Point(68, 86);
            this.textBoxSecureAddress.Name = "textBoxSecureAddress";
            this.textBoxSecureAddress.Size = new System.Drawing.Size(142, 20);
            this.textBoxSecureAddress.TabIndex = 9;
            // 
            // textBoxSecurePort
            // 
            this.textBoxSecurePort.Location = new System.Drawing.Point(249, 85);
            this.textBoxSecurePort.Name = "textBoxSecurePort";
            this.textBoxSecurePort.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecurePort.TabIndex = 10;
            // 
            // labelFtp
            // 
            this.labelFtp.AutoSize = true;
            this.labelFtp.Location = new System.Drawing.Point(13, 119);
            this.labelFtp.Name = "labelFtp";
            this.labelFtp.Size = new System.Drawing.Size(27, 13);
            this.labelFtp.TabIndex = 11;
            this.labelFtp.Text = "FTP";
            // 
            // textBoxFtpAddress
            // 
            this.textBoxFtpAddress.Location = new System.Drawing.Point(47, 111);
            this.textBoxFtpAddress.Name = "textBoxFtpAddress";
            this.textBoxFtpAddress.Size = new System.Drawing.Size(123, 20);
            this.textBoxFtpAddress.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = ":";
            // 
            // textBoxFtpPort
            // 
            this.textBoxFtpPort.Location = new System.Drawing.Point(249, 116);
            this.textBoxFtpPort.Name = "textBoxFtpPort";
            this.textBoxFtpPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxFtpPort.TabIndex = 14;
            // 
            // labelSocks
            // 
            this.labelSocks.AutoSize = true;
            this.labelSocks.Location = new System.Drawing.Point(2, 148);
            this.labelSocks.Name = "labelSocks";
            this.labelSocks.Size = new System.Drawing.Size(37, 13);
            this.labelSocks.TabIndex = 15;
            this.labelSocks.Text = "Socks";
            // 
            // textBoxSocksAddress
            // 
            this.textBoxSocksAddress.Location = new System.Drawing.Point(65, 137);
            this.textBoxSocksAddress.Name = "textBoxSocksAddress";
            this.textBoxSocksAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocksAddress.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = ":";
            // 
            // textBoxSocksPort
            // 
            this.textBoxSocksPort.Location = new System.Drawing.Point(234, 148);
            this.textBoxSocksPort.Name = "textBoxSocksPort";
            this.textBoxSocksPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocksPort.TabIndex = 18;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(132, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 19;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(234, 226);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxUseForAllProtocols
            // 
            this.checkBoxUseForAllProtocols.AutoSize = true;
            this.checkBoxUseForAllProtocols.Checked = true;
            this.checkBoxUseForAllProtocols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseForAllProtocols.Location = new System.Drawing.Point(47, 55);
            this.checkBoxUseForAllProtocols.Name = "checkBoxUseForAllProtocols";
            this.checkBoxUseForAllProtocols.Size = new System.Drawing.Size(225, 17);
            this.checkBoxUseForAllProtocols.TabIndex = 21;
            this.checkBoxUseForAllProtocols.Text = "Use the same proxy server for all protocols";
            this.checkBoxUseForAllProtocols.UseVisualStyleBackColor = true;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(5, 199);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(36, 13);
            this.lblProfile.TabIndex = 22;
            this.lblProfile.Text = "Profile";
            // 
            // textBoxProfile
            // 
            this.textBoxProfile.Location = new System.Drawing.Point(68, 191);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(100, 20);
            this.textBoxProfile.TabIndex = 23;
            // 
            // btnLdSys
            // 
            this.btnLdSys.Location = new System.Drawing.Point(337, 8);
            this.btnLdSys.Name = "btnLdSys";
            this.btnLdSys.Size = new System.Drawing.Size(128, 23);
            this.btnLdSys.TabIndex = 24;
            this.btnLdSys.Text = "Load system values";
            this.btnLdSys.UseVisualStyleBackColor = true;
            this.btnLdSys.Click += new System.EventHandler(this.btnLdSys_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 295);
            this.Controls.Add(this.btnLdSys);
            this.Controls.Add(this.textBoxProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.checkBoxUseForAllProtocols);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxSocksPort);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSocksAddress);
            this.Controls.Add(this.labelSocks);
            this.Controls.Add(this.textBoxFtpPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFtpAddress);
            this.Controls.Add(this.labelFtp);
            this.Controls.Add(this.textBoxSecurePort);
            this.Controls.Add(this.textBoxSecureAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxHttpPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProxyAddress);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSecure);
            this.Controls.Add(this.textBoxHttpAddress);
            this.Controls.Add(this.labelHttp);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxUseForAllProtocols;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.Button btnLdSys;
    }
}