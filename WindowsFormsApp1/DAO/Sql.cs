using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAO
{
    public class Sql
    {
        public DataTable get(string query)
        {
            MySqlConnection databaseConnection = null;
            MySqlDataReader reader = null;
            DataTable dTable = new DataTable();
            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=work_manage_app;";
                DataTable result = new DataTable();
                databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = commandDatabase;

                MyAdapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (databaseConnection != null)
                    databaseConnection.Close();
            }
            return dTable;
        }
        public void insert(string query)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=work_manage_app;";
            //string query = "SELECT * FROM add_type_work";
            MySqlConnection databaseConnection = null;
            MySqlDataReader reader = null;
            try
            {
                databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (databaseConnection != null)
                    databaseConnection.Close();
            }
        }
        public void update(string query)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=work_manage_app;";
            //string query = "SELECT * FROM add_type_work";
            MySqlConnection databaseConnection = null;
            MySqlDataReader reader = null;
            try
            {
                databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (databaseConnection != null)
                    databaseConnection.Close();
            }
        }
        public void delete(string query)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=work_manage_app;";
            //string query = "SELECT * FROM add_type_work";
            MySqlConnection databaseConnection = null;
            MySqlDataReader reader = null;
            try
            {
                databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                DataSet ds = new DataSet();
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (databaseConnection != null)
                    databaseConnection.Close();
            }
        }
    }
}
