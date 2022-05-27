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
        private string workID = "";
        private WorkDao workDao = new WorkDao();
        private WorkTypeDao workTypeDao = new WorkTypeDao();
        private List<ModelTypeWork> lstWorkType = new List<ModelTypeWork>();
        public AddWork()
        {
            InitializeComponent();
            loadListWorkType();
            loadDataCreate();
        }
        public AddWork(string workID, bool edit)
        {
            InitializeComponent();
            loadListWorkType();
            loadDataEdit(workID);
        }
        public AddWork(string workID)
        {
            InitializeComponent();
            loadListWorkType();
            loadDataShow(workID);
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkIsFinish_CheckedChanged(object sender, EventArgs e)
        {

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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbLoaiCV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtName.Text)){
                MessageBox.Show("Bạn cần nhập tên công việc!");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbLoaiCV.Text)){
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
            workID = Helper.Helper.RandomID(10);
            int isFinished = chkIsFinish.Checked ? 1 : 0;
            Work work = new Work(workID, txtName.Text, cbLoaiCV.Text,dateStart.Value, dateEnd.Value, txtDescription.Text, txtColor.Text, isFinished);

            workDao.insert(work);
            this.Hide();
        }
    }
}
