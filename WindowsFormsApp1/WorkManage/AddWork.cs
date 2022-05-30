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
        private List<ModelTypeWork> lstWorkType = new List<ModelTypeWork>();
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
        public AddWork(string workID, WorkManagePage form1, bool seen =false )
        {
            InitializeComponent();
            loadListWorkType();
            loadDataEdit(workID);
            this.referenceForm = form1;
            if (seen)
            {
                loadDataShow(workID);
            }
            
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
            lstWorkType = Helper.Helper.ConvertToList<ModelTypeWork>(dtWorkType);
            foreach (DataRow row in dtWorkType.Rows)
            {
                cbLoaiCV.Items.Add(row["name"]);
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 

            if (dlg.ShowDialog() == DialogResult.OK){ //Nếu nhấp vào nút OK trên hộp thoại

                txtColor.Text = dlg.Color.Name.ToString();
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
            if(data.Rows!=null&& data.Rows.Count > 0)
            {
                txtName.Text = data.Rows[0]["name"].ToString();
                txtDescription.Text = data.Rows[0]["description"].ToString();
                txtColor.Text = data.Rows[0]["backgroundColor"].ToString();
                cbLoaiCV.Text= data.Rows[0]["name"].ToString();
                cbLoaiCV.SelectedItem = data.Rows[0]["name"].ToString();
                dateStart.Value = DateTime.Parse(data.Rows[0]["startDate"].ToString());
                dateEnd.Value = DateTime.Parse(data.Rows[0]["Deadline"].ToString());
                chkIsFinish.Checked = int.Parse(data.Rows[0]["isFinished"].ToString())==1?true:false;
            }
            
        }
        private void loadDataShow(string workID)
        {
            chkIsFinish.Enabled = false;
            txtName.Enabled = false;
            cbLoaiCV.Enabled = false;
            dateStart.Enabled = false;
            dateEnd.Enabled = false;
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
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("Bạn cần nhập màu nền!");
                txtColor.Focus();
                return;
            }
            if (dateEnd.Value.CompareTo(dateStart.Value) == -1)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                txtColor.Focus();
                return;
            }
            var selectTypeWork = lstWorkType.Where(item => item.Name.Equals(cbLoaiCV.Text));
            ModelTypeWork strWorkType = new ModelTypeWork();
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
            if (string.IsNullOrEmpty(selectedWorkID))
            {
                selectedWorkID = Helper.Helper.RandomID(10);
                
                Work work = new Work(selectedWorkID, txtName.Text, strWorkType.Id, dateStart.Value, dateEnd.Value, txtDescription.Text, txtColor.Text, isFinished);

                workDao.insert(work);
            }
            else
            {
                //update
                
                Work work = new Work(selectedWorkID, txtName.Text, strWorkType.Id, dateStart.Value, dateEnd.Value, txtDescription.Text, txtColor.Text, isFinished);

                workDao.update(work);
            }
            this.referenceForm.loadData();
            this.Hide();
        }
    }
}
