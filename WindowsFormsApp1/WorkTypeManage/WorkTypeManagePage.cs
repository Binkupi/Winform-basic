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
        public WorkTypeDao workTypeDao = new WorkTypeDao();
        public Home homeReferenceForm;
        public ClientModel client;
        public int workDone = 0;
        public int workUnDone = 0;
        public int workLate = 0;

        public WorkTypeManagePage(Home form1,ClientModel client)
        {
            Console.WriteLine(this.homeReferenceForm);
            
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.client = client;
            loadData();
            // LoadList();
           
           // Console.WriteLine(this.homeReferenceForm);
            


        }


       
        public void loadData()
        {
            workTypeLayout.Controls.Clear();

            try
            {
                DataTable lstWorkType = new DataTable();
                lstWorkType = workTypeDao.getListWorkType(client);
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
                    // Console.WriteLine(this.homeReferenceForm);
                    resetStateWorkType();
                    loadStateWorkType(workType.Id.ToString());
                    listWorkTypeItems[i] = new TypeWork(this.homeReferenceForm,this, this.workDone, this.workUnDone, this.workLate, client);
                    listWorkTypeItems[i].WorkTypeID = workType.Id.ToString();
                    listWorkTypeItems[i].WorkTypeName = workType.Name;

                    listWorkTypeItems[i].bgColor = System.Drawing.ColorTranslator.FromHtml(workType.BackgroundColor);


                    listWorkTypeItems[i].Margin = new Padding(10);
                    workTypeLayout.Controls.Add(listWorkTypeItems[i]);
                    i++;
                }
                WorkTypeAdd addWorkTypeItem = new WorkTypeAdd(this, client);
                addWorkTypeItem.Margin = new Padding(10);
                workTypeLayout.Controls.Add(addWorkTypeItem);
             
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        public void resetStateWorkType()
        {
            this.workDone = 0;
            this.workUnDone = 0;
            this.workLate = 0;
        }
        public void loadStateWorkType(string WorkTypeID)
        {
            WorkDao workDao = new WorkDao();
            DataTable lstWork = new DataTable();
            lstWork = workDao.getListWorkByWorkType(WorkTypeID, client);
            DateTime today = DateTime.Now;
            var drUndoneWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 0 && today.CompareTo(item.Field<DateTime>("Deadline")) == -1);
            var drDoneWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 1);
            var drLatedWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 0 && today.CompareTo(item.Field<DateTime>("Deadline")) > 0);

            List<Work> lstUndoneWork = new List<Work>();
            List<Work> lstDoneWork = new List<Work>();
            List<Work> lstLatedWork = new List<Work>();
            if (drUndoneWork.Any())
            {
                lstUndoneWork = Helper.Helper.ConvertToList<Work>(drUndoneWork.CopyToDataTable());
                this.workUnDone = lstUndoneWork.Count;
            }
            if (drDoneWork.Any())
            {
                DataTable test = drDoneWork.CopyToDataTable();
                lstDoneWork = Helper.Helper.ConvertToList<Work>(test);
                this.workDone = lstDoneWork.Count;
            }
            if (drLatedWork.Any())
            {
                lstLatedWork = Helper.Helper.ConvertToList<Work>(drLatedWork.CopyToDataTable());
                this.workLate = lstLatedWork.Count;
            }
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
                    workTypeDao.insertExcel(workType, client);
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
            dtWorkType = workTypeDao.getListWorkType(client);
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

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(client);
            home.Show();
        }
    }
}
