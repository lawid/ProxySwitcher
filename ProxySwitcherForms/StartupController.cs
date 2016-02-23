using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProxySwitcherForms
{
    public class StartupController
    {
        private string STARTUP_ENTRY = Application.ProductName;
        public const string STARTUP_CMD = "/silent";

        private RegistryKey startupRegistry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        
        public bool CheckStartupEntry()
        {
            return startupRegistry.GetValue(STARTUP_ENTRY) != null;
        }

        public void CreateStartupEntry()
        {
            startupRegistry.SetValue(STARTUP_ENTRY, $"{Application.ExecutablePath} {STARTUP_CMD}");
        }

        public void RemoveStartupEntry()
        {
            startupRegistry.DeleteValue(STARTUP_ENTRY, false);
        }
    }
}