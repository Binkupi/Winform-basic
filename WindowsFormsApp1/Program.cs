using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

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
            //DateTime today = DateTime.Now;
            //DateTime value = DateTime.Parse(today.ToString());

            // Console.WriteLine(value);
            //Helper.Helper.sentAutoMail();

            //Helper.Helper.sentMail();
            Helper.Helper.sentAutoMessage();
            Application.Run(new Home());
        }
    }
}
