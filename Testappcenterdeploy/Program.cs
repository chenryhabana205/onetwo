using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace Testappcenterdeploy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, args) =>
            {
                Crashes.TrackError(args.Exception);
            };
            AppCenter.Start("e6fcf9e3-cf00-413e-8f2f-8b626fc92e1d",
                   typeof(Analytics), typeof(Crashes));


            Application.Run(new Form1());
        }
    }
}
