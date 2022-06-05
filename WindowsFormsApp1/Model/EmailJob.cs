using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.Model
{
    class EmailJob : IJob

    {

        public void Execute(IJobExecutionContext context)

        {
            try
            {
                WorkDao workDao = new WorkDao();
                var dt = workDao.getWorkBeforeDeadline();
                byte[] data = Helper.Helper.ExportExcelEmail(dt);
                string pathString = @"D:\text.xlsx";
                string path = Path.GetFullPath(pathString);
                File.WriteAllBytes(path, data);
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("tongdinhquoc@gmail.com", "20112000a");

                MailMessage message = new MailMessage("tongdinhquoc@gmail.com", "18521312@gm.uit.edu.vn");
                message.Subject = "18521312@gm.uit.edu.vn";
                message.Body = "Quốc quá là đẹp trai";
                message.Attachments.Add(new Attachment(path));
                mailclient.Send(message);
                MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

    }

}

