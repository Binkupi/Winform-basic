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
        public DataTable getListWorkType(ClientModel client)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM workType where clientID = "+client.id);
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return dTable;


        }

        public DataTable getWorkTypeByWorkTypeID(string id, ClientModel client)
        {
            DataTable dTable = new DataTable();
            try
            {
                dTable = sql.get("SELECT * FROM workType where id='" + id + "' and clientID = "+client.id);
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

            string query = "DELETE FROM workType WHERE id ='" + id + "' and clientID= "+client.id ;
            //string query = "DELETE FROM workType WHERE id ='" + id + "' and client= " + "'" + client.id + "'";
            bool result = sql.delete(query);
            if (result)
            {
                MessageBox.Show("xóa thành công.");
            }

        }
        public void insert(WorkType workType, ClientModel client)
        {

            string query = "INSERT INTO `workType` (`name`, `description`, `backgroundColor`,`clientID`) VALUES('" + workType.Name + "', '" + workType.Description + "', '" + workType.BackgroundColor + "'," + client.id+")";
            bool result = sql.insert(query);
            if (result)
            {
                MessageBox.Show("Lưu thành công.");
            }

        }
        public void insertExcel(WorkType workType, ClientModel client)
        {

            string query = "INSERT INTO `workType` (`name`, `description`, `backgroundColor`,`clientID`) VALUES('" + workType.Name + "', '" + workType.Description + "', '" + workType.BackgroundColor + "'," + client.id + ")";
            bool result = sql.insert(query);
        }
        public void update(WorkType workType, ClientModel client)
        {

            string query = "UPDATE `workType` SET `name` = '" + workType.Name + "',  `description`='" + workType.Description + "',`backgroundColor`= '" + workType.BackgroundColor + "' where `worktype` . `id`='" + workType.Id + "' and clientID="+ client.id;

            // MessageBox.Show(query);

            bool result = sql.update(query);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công.");
            }

        }

    }
}
