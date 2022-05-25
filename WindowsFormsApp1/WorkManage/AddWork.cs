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
            txtNote.Enabled = false;
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
    }
}
