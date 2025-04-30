using System;
using System.Windows.Forms;

namespace CaptchaGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // For .NET Core 3.1 and .NET 5+
            // ApplicationConfiguration.Initialize();

            // For .NET Framework or compatibility with both
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}