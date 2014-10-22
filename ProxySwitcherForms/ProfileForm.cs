using ProxySwitcher;
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
    public partial class ProfileForm : Form
    {

        private Profile mProfile = new Profile();

        // TODO databinding (each would have to be a property)
        private string httpProxy, httpsProxy, ftpProxy, socksProxy;
        private string httpPort, httpsPort, ftpPort, socksPort;

        private bool unifiedProtocolProxy;


        public ProfileForm()
        {

            InitializeComponent();

        }

        public ProfileForm(Profile profile)
            : this()
        {
            mProfile = profile;

            Console.WriteLine("proxy: " + mProfile.Proxy);
            ParseData(mProfile.Proxy);

            LoadData();
        }

        private void btnLdSys_Click(object sender, EventArgs e)
        {
            ParseData(new ProxyController().GetCurrentProxy());
            LoadData();
        }

        private string EncodeProxy()
        {
            // TODO if empty string omit! //TODO checkbox use for all protocols
            string proxy = "";
            if (unifiedProtocolProxy)
            {
                proxy = httpProxy + ":" + httpPort;
            }
            else
            {
                proxy = "http=" + httpProxy + ":" + httpPort + ";";
                proxy += "https=" + httpsProxy + ":" + httpsPort + ";";
                proxy += "ftp=" + ftpProxy + ":" + ftpPort + ";";

                if (socksProxy.Length != 0) proxy += "socks=" + socksProxy + ":" + socksPort + ";";

                proxy = proxy.Substring(0, proxy.Length - 1);
            }

            return proxy;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            RetrieveData();
            // TODO validate

            mProfile.Proxy = EncodeProxy();
            mProfile.Title = textBoxProfile.Text;
            Dispose();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void LoadData()
        {
            textBoxProfile.Text = mProfile.Title;

            checkBoxUseForAllProtocols.Checked = unifiedProtocolProxy;

            textBoxHttpAddress.Text = httpProxy;
            textBoxHttpPort.Text = httpPort;

            textBoxSecureAddress.Text = httpsProxy;
            textBoxSecurePort.Text = httpsPort;

            textBoxFtpAddress.Text = ftpProxy;
            textBoxFtpPort.Text = ftpPort;

            textBoxSocksAddress.Text = socksProxy;
            textBoxSocksPort.Text = socksPort;
        }

        public void RetrieveData()
        {
            unifiedProtocolProxy = checkBoxUseForAllProtocols.Checked;

            httpProxy = textBoxHttpAddress.Text;
            httpPort = textBoxHttpPort.Text;

            httpsProxy = textBoxSecureAddress.Text;
            httpsPort = textBoxSecurePort.Text;

            ftpProxy = textBoxFtpAddress.Text;
            ftpPort = textBoxFtpPort.Text;

            socksProxy = textBoxSocksAddress.Text;
            socksPort = textBoxSocksPort.Text;
        }


        internal void ParseData(string proxy)
        {
            string[] parts = proxy.Split(new char[] { ';', '=', ':' });

            if (parts.Length == 2)
            {
                httpProxy = parts[0];
                httpPort = parts[1];
                unifiedProtocolProxy = true;
            }
            else
            {
                unifiedProtocolProxy = false;
                if (parts.Length >= 3)
                {
                    httpProxy = parts[1];
                    httpPort = parts[2];
                }
                if (parts.Length >= 6)
                {
                    httpsProxy = parts[4];
                    httpsPort = parts[5];
                }
                if (parts.Length >= 9)
                {
                    ftpProxy = parts[7];
                    ftpPort = parts[8];
                }
                if (parts.Length >= 12)
                {
                    socksProxy = parts[10];
                    socksPort = parts[11];
                }
            }
        }

        public Profile GetProfile()
        {
            return mProfile;
        }

        
    }
}
