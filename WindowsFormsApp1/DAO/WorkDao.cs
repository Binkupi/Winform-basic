using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAO
{
    public class WorkDao
    {
        Sql sql = new Sql();
        public DataTable getListWork(ClientModel client)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work where clientID ="+client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public DataTable getListWorkByWorkType(string workType, ClientModel client)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work where workType = '" + workType + "' and clientID =" + client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public DataTable getWorkByWorkID(string id, ClientModel client)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work where id='" + id + "'and clientID =" + client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public DataTable getAllWorkByDate(string date1, string date2,ClientModel client)
        {
            DataTable dTable = new DataTable();
            try
            {   
                dTable = sql.get("SELECT * FROM work where deadline BETWEEN  '" + date1 + "' AND '" + date2 + "' and clientID =" + client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public DataTable getWorkTypeByWorkID(string id, ClientModel client)
        {
            DataTable dTable = new DataTable();

            try
            {
                dTable = sql.get("SELECT * FROM worktype where id='" + id + "'and clientID =" + client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }
        public void delete(string id, ClientModel client)
        {

            string query = "DELETE FROM work WHERE id ='" + id + "' and clientID =" + client.id;
            bool result = sql.delete(query);
            if (result)
            {
                MessageBox.Show("xóa thành công.");
            }

        }
        public void insert(Work work, ClientModel client)
        {

            string query = "INSERT INTO `work` (`name`, `workType`, `isNotification`, `deadline`, `description`, `alarmDate`, `isFinished`,`clientID`) VALUES('" + work.Name + "', '" + work.WorkType + "', '" + work.IsNotification + "', '" + work.Deadline.ToString("yyyy-MM-dd HH:mm") + "', '" + work.Description + "', '" + work.AlarmDate.ToString("yyyy-MM-dd HH:mm") + "'," + work.IsFinished + "," + client.id + ")";
            bool result = sql.insert(query);
            if (result)
            {
                MessageBox.Show("Lưu thành công.");
            }

        }
        public void insertExcel (Work work, ClientModel client)
        {

            string query = "INSERT INTO `work` (`name`, `workType`, `isNotification`, `deadline`, `description`, `alarmDate`, `isFinished`,`clientID`) VALUES('" + work.Name + "', '" + work.WorkType + "', '" + work.IsNotification + "', '" + work.Deadline.ToString("yyyy-MM-dd HH:mm") + "', '" + work.Description + "', '" + work.AlarmDate.ToString("yyyy-MM-dd HH:mm") + "'," + work.IsFinished + "," + client.id + ")";
            bool result = sql.insert(query);

        }
        public void update(Work work,ClientModel client)
        {
            string query = "UPDATE `work` set `name` = '" + work.Name + "', `workType` ='" + work.WorkType + "', `isNotification`='" + work.IsNotification + "', `deadline`='" + work.Deadline.ToString("yyyy-MM-dd HH:mm") + "', `description`='" + work.Description + "', `alarmDate`='" + work.AlarmDate.ToString("yyyy-MM-dd HH:mm") + "', `isFinished`= " + work.IsFinished + " where id='" + work.Id + "' and clientID =" + client.id;
            // MessageBox.Show(query);
            bool result = sql.update(query);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
            }

        }
        public DataTable getWorkBeforeDeadline(DataRow client)
        {

            DataTable dTable = new DataTable();
            DateTime today = DateTime.Now;
            try
            {
                dTable = sql.get("SELECT * FROM work where DateDiff('" + today.ToString("yyyy-MM-dd") + "',deadline)=1 and clientID ="+Int32.Parse(client["id"].ToString()));
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;
        }
        public DataTable getWorkDeadline(ClientModel client)
        {

            DataTable dTable = new DataTable();
            DateTime today = DateTime.Now;
            try
            {
                dTable = sql.get("SELECT a.name as workName, b.name as workTypeName FROM work as a inner join workType as b on a.workType = b.id where DateDiff('" + today.ToString("yyyy-MM-dd") + "',alarmDate)=0 and isNotification =1 and a.clientID =" + client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;
        }

        //public DataTable getWorkDeadline()
        //        {

        //            DataTable dTable = new DataTable();
        //            DateTime today = DateTime.Now;
        //            try
        //            {
        //                dTable = sql.get("SELECT * FROM work where DateDiff('" + today.ToString("yyyy-MM-dd") + "',deadline)=0");

        //            }
    }
}
