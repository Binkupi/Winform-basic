using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Client;

namespace WindowsFormsApp1
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
            DateTime today = DateTime.Now;
            DateTime today1 = DateTime.Now;


            //Helper.Helper.sentAutoMail();
            //Helper.Helper.sentMail();
            
            Application.Run(new LoginPage());
        }
    }
}
