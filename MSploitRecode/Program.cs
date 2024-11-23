using MSploitRecode.Classes;
using System;
using System.Windows.Forms;

namespace MSploitRecode
{
    internal static class Program
    {
        // Variables //
        public static Bootstrapper bootstrapper;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bootstrapper = new Bootstrapper();
            bootstrapper.Show();

            Application.Run();
        }

        // Fix for not closing correctly //
        public static void OnFromLoaded(object sender, EventArgs e)
        {
            Data.TotalFormsOpened += 1;
        }

        public static void OnFromClosed(object sender, FormClosedEventArgs e)
        {
            Data.TotalFormsOpened -= 1;
            if (Data.TotalFormsOpened <= 0) Application.Exit();
        }
    }
}
