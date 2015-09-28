using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher
{
    public class ProxyController
    {

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        static bool settingsReturn, refreshReturn;
        const string KEY_PROXY_ENABLE = "ProxyEnable", KEY_PROXY_SERVER = "ProxyServer";

        private RegistryKey registry;

        public ProxyController()
        {
            registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        }

        private void PropagateInternetSetOption()
        {
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public void PrintCurrentSettings()
        {
            string proxenabled = registry.GetValue(KEY_PROXY_ENABLE).ToString();
            string proxserv = registry.GetValue(KEY_PROXY_SERVER).ToString();

            Console.WriteLine("enabled " + proxenabled + " current proxy is " + proxserv);
        }

        public bool IsEnabled()
        {
            int proxenabled = (int) registry.GetValue(KEY_PROXY_ENABLE);

            return Convert.ToBoolean(proxenabled);
        }

        public bool SetEnabled(bool active)
        {
            registry.SetValue(KEY_PROXY_ENABLE, Convert.ToInt32(active));

            PropagateInternetSetOption();

            return settingsReturn && refreshReturn;
        }

        public string GetCurrentProxy()
        {
            string proxserv = registry.GetValue(KEY_PROXY_SERVER).ToString();

            return proxserv;
        }

        public bool SetProxy(string proxy)
        {
            registry.SetValue(KEY_PROXY_SERVER, proxy);

            PropagateInternetSetOption();

            return settingsReturn && refreshReturn;
        }


    }
}
