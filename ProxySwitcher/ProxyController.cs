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
        static string KProxyEnable = "ProxyEnable", KProxyServer = "ProxyServer";

        private RegistryKey getCurrentUserRegistry()
        {
            return Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        }

        private void PropagateInternetSetOption()
        {
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public void PrintCurrentSettings()
        {
            RegistryKey registry = getCurrentUserRegistry();

            string proxenabled = registry.GetValue(KProxyEnable).ToString();
            string proxserv = registry.GetValue(KProxyServer).ToString();

            Console.WriteLine("enabled " + proxenabled + " current proxy is " + proxserv);
        }

        public bool IsEnabled()
        {
            RegistryKey registry = getCurrentUserRegistry();

            int proxenabled = (int) registry.GetValue(KProxyEnable);

            return Convert.ToBoolean(proxenabled);
        }

        public bool SetEnabled(bool active)
        {
            RegistryKey registry = getCurrentUserRegistry();

            registry.SetValue(KProxyEnable, Convert.ToInt32(active));

            PropagateInternetSetOption();

            return settingsReturn && refreshReturn;
        }

        public string GetCurrentProxy()
        {
            RegistryKey registry = getCurrentUserRegistry();

            string proxserv = registry.GetValue(KProxyServer).ToString();

            return proxserv;
        }

        public bool SetProxy(string proxy)
        {
            RegistryKey registry = getCurrentUserRegistry();
            registry.SetValue(KProxyServer, proxy);

            PropagateInternetSetOption();

            return settingsReturn && refreshReturn;
        }


    }
}
