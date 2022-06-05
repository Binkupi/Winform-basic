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
                    listWorkTypeItems[i].WorkTypeID = workType.Id.ToString();
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
            try
            {
                DataTable dtWorkType = new DataTable("WorkType");
                Helper.Helper.ImportExcel(ref dtWorkType);
                DataTable dtWorkTypeExcel = new DataTable("WorkTypeExcel");
                dtWorkTypeExcel.Columns.Add("name", typeof(string));
                dtWorkTypeExcel.Columns.Add("description", typeof(string));
                dtWorkTypeExcel.Columns.Add("backgroundColor", typeof(string));
                foreach (DataRow row in dtWorkType.Rows)
                {
                    DataRow rowExel = dtWorkTypeExcel.NewRow();
                    rowExel["name"] = row["Tên loại công việc"].ToString();
                    rowExel["description"] = row["Mô tả loại công việc"].ToString();
                    rowExel["backgroundColor"] = row["Màu sắc"].ToString();
                    dtWorkTypeExcel.Rows.Add(rowExel);
                }

                List<WorkType> lstWorkType = new List<WorkType>();

                lstWorkType = Helper.Helper.ConvertToList<WorkType>(dtWorkTypeExcel);
                foreach (WorkType workType in lstWorkType)
                {
                    workTypeDao.insertExcel(workType);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnDefaultExport_Click(object sender, EventArgs e)
        {
            DataTable dtWorkExcel = new DataTable("dtWorkExcel");
            dtWorkExcel.Columns.Add("Tên loại công việc", typeof(string));
            dtWorkExcel.Columns.Add("Mô tả loại công việc", typeof(string));
            dtWorkExcel.Columns.Add("Màu sắc", typeof(string));
            Helper.Helper.ExportDefaultExcel(dtWorkExcel);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataTable dtWorkType = new DataTable("WorkType");
            dtWorkType = workTypeDao.getListWorkType();
            if (dtWorkType != null && dtWorkType.Rows.Count == 0)
            {
                throw new Exception("Không có dữ liệu xuất");
            }
            DataTable dtWorkExcel = new DataTable("dtWorkExcel");
            dtWorkExcel.Columns.Add("Tên loại công việc", typeof(string));
            dtWorkExcel.Columns.Add("Mô tả loại công việc", typeof(string));
            dtWorkExcel.Columns.Add("Màu sắc", typeof(string));
            foreach (DataRow row in dtWorkType.Rows)
            {

                DataRow rowExel = dtWorkExcel.NewRow();
                rowExel["Tên loại công việc"] = row["name"].ToString();
                rowExel["Mô tả loại công việc"] = row["description"].ToString();
                rowExel["Màu sắc"] = row["backgroundColor"].ToString();
                dtWorkExcel.Rows.Add(rowExel);

            }
            Helper.Helper.ExportExcel(dtWorkExcel);
        }

        private void flPanel_layout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
