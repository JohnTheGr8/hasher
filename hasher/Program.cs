using System;
using System.Linq;
using System.Windows.Forms;

namespace hasher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Any())
            {
                // pass the first file path
                Form1.ArgFile = args[0];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
