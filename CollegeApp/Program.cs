using System;
using System.Windows.Forms;

namespace CollegeApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application visual styles and fonts
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with LoginForm
            Application.Run(new LoginForm());
        }
    }
}