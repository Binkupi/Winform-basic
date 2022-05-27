using System;
using WindowsFormsApp1.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.WorkTypeManage;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class WorkTypeManagePage : Form
    {
        List<ModelTypeWork> listTypeWorkItem = new List<ModelTypeWork>();
     
        public WorkTypeManagePage()
        {
            InitializeComponent();
            loadData();
            LoadList();
            
        }


       
        private void loadData()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=work_manage_app;";
            string query = "SELECT * FROM add_type_work";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
              
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ModelTypeWork typeWorkItem = new ModelTypeWork();
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        //Console.WriteLine(reader.GetString(0) +"-"+ reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3));
                        string temp = reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3);
                        Console.WriteLine(temp);
                        //showQuerry.Items.Add(temp);
                        typeWorkItem.Id = reader.GetString(0);
                        typeWorkItem.Name = reader.GetString(1);
                        typeWorkItem.Description = reader.GetString(2);
                        typeWorkItem.BackgroundColor = reader.GetString(3);
                        
                        listTypeWorkItem.Add(typeWorkItem);

                        
                    }

                }
                else
                {
                    Console.WriteLine("No rows found.");
                }


                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadList()
        {
            flPanel_layout.Controls.Clear();
            var listItems = new TypeWork[listTypeWorkItem.Count];
            //var listItems = new TypeWork[100];

            //int i = 0;

            //listItems[i] = new TypeWork();


            //listItems[i].WorkTypeName = listTypeWorkItem[1].NameTypeWork;
            //listItems[i].WorkTypeDescription = listTypeWorkItem[1].Description;
            //listItems[i].Margin = new Padding(30);
            //listItems[i].Click += new System.EventHandler(this.item_Clicked);
            //flPanel_layout.Controls.Add(listItems[i]);

            //i = 1;
            //listItems[i] = new TypeWork();
            //listItems[i].WorkTypeName = "test1";
            //listItems[i].WorkTypeDescription = "mô tả 1";
            //listItems[i].Margin = new Padding(30);
            //listItems[i].Click += new System.EventHandler(this.item_Clicked);
            //flPanel_layout.Controls.Add(listItems[i]);

            //i = 3;
            //listItems[i] = new TypeWork();
            //listItems[i].WorkTypeName = "test1";
            //listItems[i].WorkTypeDescription = "mô tả 1";
            //listItems[i].Margin = new Padding(30);
            //listItems[i].Click += new System.EventHandler(this.item_Clicked);
            //flPanel_layout.Controls.Add(listItems[i]);

            //i = 4;
            //listItems[i] = new TypeWork();
            //listItems[i].WorkTypeName = "test1";
            //listItems[i].WorkTypeDescription = "mô tả 1";
            //listItems[i].Margin = new Padding(30);
            //listItems[i].Click += new System.EventHandler(this.item_Clicked);
            //flPanel_layout.Controls.Add(listItems[i]);

            //i = 5;
            //listItems[i] = new TypeWork();
            //listItems[i].WorkTypeName = "test1";
            //listItems[i].WorkTypeDescription = "mô tả 1";
            //listItems[i].Margin = new Padding(30);
            //listItems[i].Click += new System.EventHandler(this.item_Clicked);
            //flPanel_layout.Controls.Add(listItems[i]);


            //listItems[i].Click += new System.EventHandler(this.item_Clicked);
            //flPanel_layout.Controls.Add(listItems[i]);
            //var data = new WorkTypeAdd();
            //data.Margin = new Padding(30);
            //data.Click += new System.EventHandler(this.item_Add);
            //flPanel_layout.Controls.Add(data);

            //TypeWork item = new TypeWork();

            for (int i =0; i<listTypeWorkItem.Count;i++)
            {
                listItems[i] = new TypeWork();
                listItems[i].WorkTypeName = listTypeWorkItem[i].Name;
                listItems[i].WorkTypeDescription = listTypeWorkItem[i].Description;
                listItems[i].Margin = new Padding(30);
                listItems[i].Click += new System.EventHandler(this.item_Clicked);
                flPanel_layout.Controls.Add(listItems[i]);


                //item.WorkTypeName = listTypeWorkItem[i].NameTypeWork;
                //item.WorkTypeDescription = listTypeWorkItem[i].Description;
                //item.Margin = new Padding(30);
                //item.Click += new System.EventHandler(this.item_Clicked);
                //flPanel_layout.Controls.Add(item);
            }


            var data = new WorkTypeAdd();
            data.Margin = new Padding(30);
            data.Click += new System.EventHandler(this.item_Add);
            flPanel_layout.Controls.Add(data);

            
        }
       

        private void item_Clicked(object sender, EventArgs e)
        {
            var item = (TypeWork)sender;
            var selectProduct = new TypeWork();
           
        }
        private void item_Add(object sender, EventArgs e)
        {
            //var item = (AddWorkItem)sender;
            var item = (WorkTypeAdd)sender;
            MessageBox.Show("Add");
        }

        private void WorkTypeManage_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataTable dtWork = new DataTable("Work");
            Helper.Helper.ImportExcel(ref dtWork);
        }

        private void btnDefaultExport_Click(object sender, EventArgs e)
        {
            DataTable dtWork = new DataTable("Work");
            dtWork.Columns.Add("Loại công việc", typeof(string));
            dtWork.Columns.Add("Tên công việc", typeof(string));
            DataRow row = dtWork.NewRow();
            row["Loại công việc"] = "1";
            row["Tên công việc"] = "Quoooooooc";
            dtWork.Rows.Add(row);
            Helper.Helper.ExportExcel(dtWork);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataTable dtWork = new DataTable("Work");
            dtWork.Columns.Add("Loại công việc", typeof(string));
            dtWork.Columns.Add("Tên công việc", typeof(string));
            DataRow row = dtWork.NewRow();
            row["Loại công việc"] = "1";
            row["Tên công việc"] = "Quoooooooc";
            Helper.Helper.ExportDefaultExcel(dtWork);
        }

        private void flPanel_layout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
