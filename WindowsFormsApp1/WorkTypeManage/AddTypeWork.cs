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
    public partial class AddTypeWork : Form
    {
        private string selectedWorkTypeID = "";
      //  private WorkDao workDao = new WorkDao();
        private WorkTypeDao workTypeDao = new WorkTypeDao();
        private List<WorkType> lstWorkType = new List<WorkType>();
        public WorkTypeManagePage workTypereferenceForm;
        private ClientModel client;
        public AddTypeWork()
        {
            InitializeComponent();
            loadDataEdit(selectedWorkTypeID);
        }
        public AddTypeWork(string workTypeID, ClientModel client)
        {
            InitializeComponent();
            this.client = client;
            loadDataEdit(workTypeID);


        }
        public AddTypeWork(WorkTypeManagePage form1, ClientModel client)
        {
            InitializeComponent();
            this.client = client;
            loadDataEdit(selectedWorkTypeID);
            this.workTypereferenceForm = form1;
        }
        public AddTypeWork(string workTypeID, WorkTypeManagePage form1,ClientModel client, bool seen = false)
        {
            InitializeComponent();

            this.workTypereferenceForm = form1;
            this.client = client;
            if (seen)
            {
                loadDataShow(workTypeID);
            }

        }

        public AddTypeWork(string workTypeID, WorkTypeManagePage form1, ClientModel client)
        {
            InitializeComponent();
            this.client = client;
            loadDataEdit(workTypeID);
            this.workTypereferenceForm = form1;
        }
      
       

        private void loadDataEdit(string workTypeID)
        {
            
            selectedWorkTypeID = workTypeID;
            DataTable data = workTypeDao.getWorkTypeByWorkTypeID(selectedWorkTypeID, client) ;
            if (data.Rows != null && data.Rows.Count > 0)
            {
                txtName.Text = data.Rows[0]["name"].ToString();
                txtDescription.Text = data.Rows[0]["description"].ToString();
                txtColor.Text = data.Rows[0]["backgroundColor"].ToString();
                //cbLoaiCV.Text = data.Rows[0]["name"].ToString();
                //cbLoaiCV.SelectedItem = data.Rows[0]["name"].ToString();
                //dateStart.Value = DateTime.Parse(data.Rows[0]["startDate"].ToString());
                //dateEnd.Value = DateTime.Parse(data.Rows[0]["Deadline"].ToString());
                //chkIsFinish.Checked = int.Parse(data.Rows[0]["isFinished"].ToString()) == 1 ? true : false;
            }

        }

        
        private void loadDataShow(string workTypeID)
        {
          
            txtName.Enabled = false;
          
            txtDescription.Enabled = false;
        }
       

   

   

        

        private string backgroundColor = "";
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 

            if (dlg.ShowDialog() == DialogResult.OK)
            { //Nếu nhấp vào nút OK trên hộp thoại

               // txtColor.Text = dlg.Color.Name.ToString();
                txtColor.Text = "#" + dlg.Color.Name.ToString();
            }
        }

        private void btnSubmitWorkType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn cần nhập tên công việc!");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Bạn cần nhập mô tả loại công việc!");
                txtDescription.Focus();
                return;
            }
           
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("Bạn cần nhập màu nền!");
                txtColor.Focus();
                return;
            }
           
          

          
            if (string.IsNullOrEmpty(selectedWorkTypeID))
            {
                //selectedWorkTypeID = Helper.Helper.RandomID(10);

                WorkType workType = new WorkType(txtName.Text, txtDescription.Text, txtColor.Text);

                workTypeDao.insert(workType, client);
            }
            else
            {
                //update


                WorkType workType = new WorkType(Int32.Parse(selectedWorkTypeID), txtName.Text, txtDescription.Text, txtColor.Text);

                workTypeDao.update(workType, client);
            }
            this.workTypereferenceForm.loadData();
            this.Hide();
        }

        private void btnCancelWorkType_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
