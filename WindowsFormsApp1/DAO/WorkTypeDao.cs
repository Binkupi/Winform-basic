using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
