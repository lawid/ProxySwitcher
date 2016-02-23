using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace ProxySwitcher
{
    public class ProxyController
    {
        public static ProxyController Instance { get; } = new ProxyController();

        [DllImport("wininet.dll")]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;
        private bool settingsReturn, refreshReturn;
        private const string KEY_PROXY_ENABLE = "ProxyEnable", KEY_PROXY_SERVER = "ProxyServer";

        private RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
        
        private bool PropagateInternetSetOption()
        {
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            return settingsReturn && refreshReturn;
        }

        public bool IsEnabled()
        {
            int proxenabled = (int)registry.GetValue(KEY_PROXY_ENABLE);
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
            return registry.GetValue(KEY_PROXY_SERVER).ToString();
        }

        public bool SetProxy(string proxy)
        {
            registry.SetValue(KEY_PROXY_SERVER, proxy);
            PropagateInternetSetOption();
            return settingsReturn && refreshReturn;
        }

        public bool ActivateProxy(Profile proxy)
        {
            return SetProxy(proxy.Proxy) && SetEnabled(true);
        }

        public void PrintCurrentSettings() => WriteLine($"Current proxy: {GetCurrentProxy()}, enabled: {IsEnabled()}");
    }
}
