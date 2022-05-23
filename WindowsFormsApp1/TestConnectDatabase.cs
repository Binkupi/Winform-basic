using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class TestConnectDatabase : Form
    {

        public TestConnectDatabase()
        {
            InitializeComponent();
        }

        private void TestConnectDatabase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            runQuerry();
        }

        private void runQuerry()
        {
            // Change the username, password and database according to your needs
            // You can ignore the database option if you want to access all of them.
            // 127.0.0.1 stands for localhost and the default port to connect.
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=connect_winform;";
            // Your query,
            string query = "SELECT * FROM user";

            // Prepare the connection
            //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            //commandDatabase.CommandTimeout = 60;
            //MySqlDataReader reader;

            // Let's do it !
            //try
            //{
            //    // Open the database
            //    databaseConnection.Open();

            //    // Execute the query
            //    reader = commandDatabase.ExecuteReader();

            //    // All succesfully executed, now do something

            //    // IMPORTANT : 
            //    // If your query returns result, use the following processor :

            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
            //            // Do something with every received database ROW
            //            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
            //            //Console.WriteLine(reader.GetString(0) +"-"+ reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3));
            //            string temp = reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3);
            //            Console.WriteLine(temp);
            //            showQuerry.Items.Add(temp);

            //        }




            //    }
            //    else
            //    {
            //        Console.WriteLine("No rows found.");
            //    }

            //    // Finally close the connection
            //    databaseConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    // Show any error message.
            //    MessageBox.Show(ex.Message);
            //}
        }

    }
}
