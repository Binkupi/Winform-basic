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
        public DataTable getData()
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM work");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;
            

        }
        public void delete(string id)
        {
            try
            {   
                string query = "DELETE FROM work WHERE id ='"+id+"'";
                 sql.delete (query);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }
        public void insert(Work work)
        {
            try
            {
                string query = "INSERT INTO `work` (`id`, `name`, `workType`, `startDate`, `deadline`, `description`, `backgroundColor`, `isFinished`) VALUES('"+work.Id+"', '"+work.Name+"', '"+work.WorkType+"', '"+work.StartDate.ToString("yyyy-MM-dd HH:mm") + "', '"+work.Deadline.ToString("yyyy-MM-dd HH:mm") + "', '"+work.Description+"', '"+work.BackgroundColor+"',"+work.IsFinished+")";
                sql.insert(query);
                MessageBox.Show("Lưu thành công.");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

    }
}
