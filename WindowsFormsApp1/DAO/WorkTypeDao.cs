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
    public class WorkTypeDao
    {
        Sql sql = new Sql();
        public DataTable getListWorkType()
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM workType");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }

        public DataTable getWorkTypeByWorkTypeID(string id)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM workType where id='" + id + "'");
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

            string query = "DELETE FROM workType WHERE id ='" + id + "'";
            bool result = sql.delete(query);
            if (result)
            {
                MessageBox.Show("xóa thành công.");
            }

        }
        public void insert(WorkType workType)
        {

            string query = "INSERT INTO `workType` (`id`, `name`, `description`, `backgroundColor`) VALUES('" + workType.Id + "', '" + workType.Name + "', '" + workType.Description + "', '" + workType.BackgroundColor + "')";
            bool result = sql.insert(query);
            if (result)
            {
                MessageBox.Show("Lưu thành công.");
            }

        }
        public void update(WorkType workType)
        {

            string query = "UPDATE `workType` SET `name` = '" + workType.Name + "',  `description`='" + workType.Description + "',`backgroundColor`= '" + workType.BackgroundColor + "' where `worktype` . `id`='" + workType.Id + "'";

            // MessageBox.Show(query);

            bool result = sql.update(query);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
            }

        }

    }
}
