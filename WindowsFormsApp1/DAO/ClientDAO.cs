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
    public class ClientDAO
    {
        Sql sql = new Sql();
        public ClientModel getInfoClient(ClientModel client)
        {
            ClientModel clientModel = null;
            try
            {
                DataTable dTable = new DataTable();
                dTable = sql.get("SELECT * FROM client where name = '"+client.name+"'and password = '"+client.password+"'");
                if(dTable!=null && dTable.Rows.Count > 0)
                {
                    clientModel = Helper.Helper.ConvertToList<ClientModel>(dTable)[0];
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
                return null;
            }
            return clientModel;


        }
        public bool  insertClient(ClientModel client)
        {
            bool result = false;
            try
            {
               
                result = sql.insert("INSERT INTO client (name, password, email)VALUES('"+client.name+"', '"+client.password+"', '"+client.email+"')");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
                return false;
            }
            return result;

        }
        public bool update(string email, string password)
        {
            bool result = false;
            try
            {
                string query = "UPDATE `client` set `password` = '" + password + " where email='" + email + "'";
                // MessageBox.Show(query);
                result = sql.update(query);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return result;
            

        }
    }
}
