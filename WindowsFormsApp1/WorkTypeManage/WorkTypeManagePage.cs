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
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;


namespace WindowsFormsApp1
{
    public partial class WorkTypeManagePage : Form
    {
        List<WorkType> listTypeWorkItem = new List<WorkType>();
        private WorkTypeDao workTypeDao = new WorkTypeDao();

        public WorkTypeManagePage()
        {
            InitializeComponent();
            loadData();
           // LoadList();
            
        }


       
        public void loadData()
        {
            workTypeLayout.Controls.Clear();

            try
            {
                DataTable lstWorkType = new DataTable();
                lstWorkType = workTypeDao.getListWorkType();
                var lstWorkTypeAll = lstWorkType.AsEnumerable(); ;
                List<WorkType> workTypeList = new List<WorkType>();



                if (lstWorkTypeAll.Any())
                {
                    workTypeList = Helper.Helper.ConvertToList<WorkType>(lstWorkTypeAll.CopyToDataTable());
                }
       
                var listWorkTypeItems = new TypeWork[100];
                int i = 0;
                foreach (WorkType workType in workTypeList)
                {
                    listWorkTypeItems[i] = new TypeWork(this);
                    listWorkTypeItems[i].WorkTypeID = workType.Id;
                    listWorkTypeItems[i].WorkTypeName = workType.Name;

                    listWorkTypeItems[i].bgColor = System.Drawing.ColorTranslator.FromHtml(workType.BackgroundColor);


                    listWorkTypeItems[i].Margin = new Padding(10);
                    workTypeLayout.Controls.Add(listWorkTypeItems[i]);
                    i++;
                }
                WorkTypeAdd addWorkTypeItem = new WorkTypeAdd(this);
                addWorkTypeItem.Margin = new Padding(10);
                workTypeLayout.Controls.Add(addWorkTypeItem);
             
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void LoadList()
        {
            workTypeLayout.Controls.Clear();
            var listItems = new TypeWork[listTypeWorkItem.Count];
            

            for (int i =0; i<listTypeWorkItem.Count;i++)
            {
                listItems[i] = new TypeWork();
                listItems[i].WorkTypeName = listTypeWorkItem[i].Name;
                //listItems[i].WorkTypeDescription = listTypeWorkItem[i].Description;
                listItems[i].Margin = new Padding(30);
                listItems[i].Click += new System.EventHandler(this.item_Clicked);
                workTypeLayout.Controls.Add(listItems[i]);


            }


            var data = new WorkTypeAdd();
            data.Margin = new Padding(30);
            data.Click += new System.EventHandler(this.item_Add);
            workTypeLayout.Controls.Add(data);

            
        }
       

        private void item_Clicked(object sender, EventArgs e)
        {
            var item = (TypeWork)sender;
            var selectProduct = new TypeWork();
           
        }
        private void item_Add(object sender, EventArgs e)
        {
           
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
            //if(dtWork!=null&& dtWork.Rows.Count>0)
            //{
            //    dtWork
            //}
           //foreach()
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
            dtWork = workTypeDao.getListWorkType();
            Helper.Helper.ExportDefaultExcel(dtWork);
        }

        private void flPanel_layout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
