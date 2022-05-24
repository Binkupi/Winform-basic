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
    public partial class AddTypeWork : Form
    {
        public AddTypeWork()
        {
            InitializeComponent();
        }
        
        public AddTypeWork(string workID)
        {
            InitializeComponent();
            loadDataShow(workID);
        }
        
        private void loadDataShow(string workID)
        {
          
            txtName.Enabled = false;
          
            txtNote.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddTypeWork_Load(object sender, EventArgs e)
        {

        }
        private string backgroundColor = "";
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); //Khởi tạo đối tượng ColorDialog 

            if (dlg.ShowDialog() == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                backgroundColor = dlg.Color.Name; //Trả lại tên của màu đã lựa chọn
                MessageBox.Show(backgroundColor); //Hiển thị lên MessageBox
               
            }
        }
    }
}
