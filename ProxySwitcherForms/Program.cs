using System;
using System.Windows.Forms;

namespace ProxySwitcherForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var app = new ProxySwitcherForm();

            if (args.Length > 0 && args[0] == StartupController.STARTUP_CMD)
            {
                app.VisibilityAllowed = false;
            }

            Application.Run(app);
        }
    }
}
