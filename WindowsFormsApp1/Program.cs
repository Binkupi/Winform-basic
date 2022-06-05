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

            //Helper.Helper.sentAutoMail();
            //Helper.Helper.sentMail();
            //Helper.Helper.sentAutoMessage();
            DateTimePicker today = new DateTimePicker();
            today.Value = DateTime.Now;
            
            Console.WriteLine(today.Value.ToString("yyyy-mm-dd"));



            Application.Run(new Home());
        }
    }
}
