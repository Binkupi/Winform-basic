using Quartz;
using System;
using System.Collections.Generic;
using System.Data;
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
               ClientDAO clientDao = new ClientDAO();
                var dtClient = clientDao.getListClient();
                WorkDao workDao = new WorkDao();
                
                foreach (DataRow client in dtClient.Rows)
                {
                    var dt = workDao.getWorkBeforeDeadline(client);
                    DataTable dtWork = new DataTable("Work");
                    dtWork.Columns.Add("Tên công việc", typeof(string));
                    dtWork.Columns.Add("Mã loại công việc", typeof(string));
                    dtWork.Columns.Add("Mô tả công việc", typeof(string));
                    dtWork.Columns.Add("Ngày kết thúc", typeof(string));
                    dtWork.Columns.Add("Có nhận thông báo", typeof(int));
                    dtWork.Columns.Add("Ngày thông báo", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {

                        DataRow rowExel = dtWork.NewRow();
                        rowExel["Tên công việc"] = row["name"].ToString();
                        rowExel["Mã loại công việc"] = row["workType"].ToString();
                        rowExel["Mô tả công việc"] = row["description"].ToString();
                        rowExel["Ngày kết thúc"] = DateTime.Parse(row["deadline"].ToString()).ToString("dd/MM/yyyy");
                        rowExel["Có nhận thông báo"] = row["isNotification"].ToString();
                        rowExel["Ngày thông báo"] = DateTime.Parse(row["alarmDate"].ToString()).ToString("dd/MM/yyyy");
                        dtWork.Rows.Add(rowExel);

                    }
                    if(dtWork!=null && dtWork.Rows.Count > 0)
                    {
                        byte[] data = Helper.Helper.ExportExcelEmail(dtWork);
                        string pathString = @"D:\listWork.xlsx";
                        string path = Path.GetFullPath(pathString);
                        File.WriteAllBytes(path, data);
                        SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                        mailclient.EnableSsl = true;
                        mailclient.Credentials = new NetworkCredential("tongdinhquoc@gmail.com", "mlqktktyqjdsursk");
                        DateTime today = DateTime.Now;
                        MailMessage message = new MailMessage("tongdinhquoc@gmail.com", "18521312@gm.uit.edu.vn");
                        message.Subject = client["email"].ToString();
                        message.Body = "Công việc chưa hoàn thành trước ngày" + today.ToString("dd-MM-yyyy");
                        message.Attachments.Add(new Attachment(path));
                        mailclient.Send(message);
                        
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

    }

}

