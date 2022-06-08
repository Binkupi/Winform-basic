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
            JobDataMap dataMap = context.JobDetail.JobDataMap;

            ClientModel client = (ClientModel)dataMap["client"];
            WorkDao workDao = new WorkDao();
            var dt = workDao.getWorkDeadline(client);
            List<WorkCustom> lst = new List<WorkCustom>();
            string content = " Bạn không có công việc cần hoàn tất hôm nay!";
            if (dt != null && dt.Rows.Count > 0)
            {
                content = "Hôm nay bạn cần hoàn tất những công việc sau: \n";
                lst = Helper.Helper.ConvertToList<WorkCustom>(dt);
            }
            foreach (WorkCustom work in lst)
            {
                content += "Ngày " + work.workTypeName + ": " + work.workName + "\n";
            }
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show(content);
            }
           
        }

    }
}

