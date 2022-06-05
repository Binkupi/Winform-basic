using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.Model
{
    class NotificationJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            WorkDao workDao = new WorkDao();
            var dt = workDao.getWorkDeadline();
            List<Work> lst = new List<Work>();
            string content = " Bạn không có công việc cần hoàn tất hôm nay!";
            if (dt != null && dt.Rows.Count > 0)
            {
                content = "Hôm nay bạn cần hoàn tất những công việc sau: \n";
                lst = Helper.Helper.ConvertToList<Work>(dt);
            }
            foreach (Work work in lst)
            {
                content += "Ngày " + work.Deadline.ToString("dd-MM-yyyy") + ": " + work.Name + "\n";
            }
            MessageBox.Show(content);
        }

    }
}

