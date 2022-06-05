using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class AddWork : Form
    {   
        private string selectedWorkID = "";
        private WorkDao workDao = new WorkDao();
        private WorkTypeDao workTypeDao = new WorkTypeDao();
        private List<WorkType> lstWorkType = new List<WorkType>();
        private WorkManagePage referenceForm;
        public AddWork()
        {
            InitializeComponent();
            loadListWorkType();
            loadDataCreate();
        }
        public AddWork(WorkManagePage form1)
        {
            InitializeComponent();
            loadListWorkType();
            loadDataCreate();
            this.referenceForm = form1;
        }
        public AddWork(string workID, WorkManagePage form1, bool seen )
        {

            InitializeComponent();            
            loadListWorkType();
            loadDataEdit(workID);
            
            if (seen == true)
            {                          
                //btnSubmit.Text = "Cập nhật";
                btnSubmit.Visible = false;
                loadDataShow(workID);
            } else
            {
                //lblStateWork.Visible = true;
                chkIsFinish.Visible = true;
                chkIsFinish.Enabled = true;
                btnSubmit.Text = "Cập nhật";
            }
            this.referenceForm = form1;



        }


        public AddWork(string workID, WorkManagePage form1)
        {
            InitializeComponent();
            loadListWorkType();
            
            loadDataEdit(workID);
            this.referenceForm = form1;
        }
        private void loadListWorkType()
        {
            DataTable dtWorkType = workTypeDao.getListWorkType();
            lstWorkType = Helper.Helper.ConvertToList<WorkType>(dtWorkType);
            foreach (DataRow row in dtWorkType.Rows)
            {
                cbLoaiCV.Items.Add(row["name"]);
            }
        }

     
        private void loadDataCreate()
        {
            chkIsFinish.Enabled = false;
        }
        private void loadDataEdit(string workID)
        {
            chkIsFinish.Enabled = true;
            selectedWorkID = workID;
            DataTable data= workDao.getWorkByWorkID(selectedWorkID);
            string idWorkType = data.Rows[0]["workType"].ToString();
            DataTable workType = workDao.getWorkTypeByWorkID(idWorkType);
            //MessageBox.Show(workType.Rows[0]["name"].ToString());
            //MessageBox.Show(data.Rows[0]["name"].ToString());
          

            if (data.Rows!=null&& data.Rows.Count > 0)
            {
                txtName.Text = data.Rows[0]["name"].ToString();
                txtDescription.Text = data.Rows[0]["description"].ToString();
                cbLoaiCV.Text= workType.Rows[0]["name"].ToString();
                cbLoaiCV.SelectedItem = data.Rows[0]["name"].ToString();               
                chkIsNotification.Checked = int.Parse(data.Rows[0]["isNotification"].ToString()) == 1 ? true : false;
                dateEnd.Value = DateTime.Parse(data.Rows[0]["Deadline"].ToString());
                alarmDate.Value = DateTime.Parse(data.Rows[0]["alarmDate"].ToString());
                chkIsFinish.Checked = int.Parse(data.Rows[0]["isFinished"].ToString())==1?true:false;
            }
            
        }
        private void loadDataShow(string workID)
        {
            chkIsFinish.Enabled = false;
            txtName.Enabled = false;
            cbLoaiCV.Enabled = false;
            chkIsNotification.Enabled = false;
            dateEnd.Enabled = false;
            alarmDate.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn cần nhập tên công việc!");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbLoaiCV.Text))
            {
                MessageBox.Show("Bạn cần nhập loại công việc!");
                cbLoaiCV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Bạn cần nhập mô tả công việc!");
                txtDescription.Focus();
                return;
            }
      
           
            
            var selectTypeWork = lstWorkType.Where(item => item.Name.Equals(cbLoaiCV.Text));
            WorkType strWorkType = new WorkType();
            if (selectTypeWork.Any())
            {
                strWorkType = selectTypeWork.First(item => item.Name.Equals(cbLoaiCV.Text));
            }
            else
            {
                MessageBox.Show("Loại công việc không tồn tại vui lòng nhập lại!");
                cbLoaiCV.Focus();
                return;
            }

            int isFinished = chkIsFinish.Checked ? 1 : 0;
            int isNotification = chkIsNotification.Checked ? 1 : 0;
            string idWorkType;
            if (string.IsNullOrEmpty(selectedWorkID))
            {
                //selectedWorkID = Helper.Helper.RandomID(10);
                
                Work work = new Work(txtName.Text, strWorkType.Id.ToString(), isNotification, dateEnd.Value, txtDescription.Text, alarmDate.Value, isFinished);
                idWorkType = strWorkType.Id.ToString();

                workDao.insert(work);
                this.referenceForm.loadData(idWorkType);
                this.Hide();
            }
            else
            {
                //update
                
                Work work = new Work(Int32.Parse(selectedWorkID), txtName.Text, strWorkType.Id.ToString(), isNotification, dateEnd.Value, txtDescription.Text, alarmDate.Value, isFinished);
                idWorkType = strWorkType.Id.ToString();
                workDao.update(work);
                this.referenceForm.loadData(idWorkType);
                this.Hide();
            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
