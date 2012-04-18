using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NPowerTray
{
    static class Program
    {
        public static readonly RegistryKey BaseKey = Registry.CurrentUser;
        public const string AppKey = "SOFTWARE\\NPowerTray";

        private class CustomAppContext : ApplicationContext
        {
            public CustomAppContext(Form form)
            {
                form.Closed += form_Closed;
            }

            void form_Closed(object sender, EventArgs e)
            {
                OnMainFormClosed(sender, e);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new NPowerTray();
            form.Hide(); 
            
            var ac = new CustomAppContext(form);

            Application.Run(ac);
        }
    }
}
