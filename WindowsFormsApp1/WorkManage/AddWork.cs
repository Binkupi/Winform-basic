using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddWork : Form
    {
        public AddWork()
        {
            InitializeComponent();

            loadDataCreate();
        }
        public AddWork(string workID, bool edit)
        {
            InitializeComponent();
            loadDataEdit(workID);
        }
        public AddWork(string workID)
        {
            InitializeComponent();
            loadDataShow(workID);
        }
        private string backgroundColor = "";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                backgroundColor = dlg.Color.Name; //Trả lại tên của màu đã lựa chọn
                MessageBox.Show(backgroundColor); //Hiển thị lên MessageBox
                MessageBox.Show(dateStart.Value.ToString());
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
            txtNote.Enabled = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
