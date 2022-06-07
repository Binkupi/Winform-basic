using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class TypeWork : UserControl
    {
        public WorkTypeManagePage workTypeReferenceForm;
        public Home homeReferenceForm;
        public ClientModel client;
        public TypeWork()
        {
            InitializeComponent();
        }
        public TypeWork(Home form1, WorkTypeManagePage form2, ClientModel client)
        {
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.workTypeReferenceForm = form2;
            this.client = client;
        }

        private void TypeWork_Load(object sender, EventArgs e)
        {

        }
        public string WorkTypeName
        {
            get => txtWorkTypeName.Text;
            set
            {
                // trim if title is too long
                string txt = string.Copy(value);
                if (WorkTypeName.Length != 0)
                {
                    int i = txt.Length;
                    while (TextRenderer.MeasureText(txt, txtWorkTypeName.Font).Width > txtWorkTypeName.Width - 6)
                    {
                        txt = value.Substring(0, --i);
                        if (i == 0) break;
                    }
                    txtWorkTypeName.Text = txt;
                }
                else
                {
                    txtWorkTypeName.Text = value;
                }
            }
        }

        public string WorkTypeID { get; set; }

        //public string WorkTypeDescription
        //{
        //    get => txtDescription.Text;
        //    set
        //    {
        //        txtDescription.Text = value;
        //    }

        //}

        public Color bgColor
        {
            get => backgroundcolor.BackColor;
            set
            {
                backgroundcolor.BackColor = value;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            string message = "Bạn có muốn xóa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                WorkTypeDao workTypeDao = new WorkTypeDao();
                workTypeDao.delete(WorkTypeID, client) ;
                workTypeReferenceForm.loadData();
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddTypeWork addTypeWork = new AddTypeWork(WorkTypeID, workTypeReferenceForm, client);
            addTypeWork.Show();
        }



        private void backgroundcolor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
           
        }

        private void backgroundcolor_Click(object sender, EventArgs e)
        {

            WorkManagePage work = new WorkManagePage(homeReferenceForm, workTypeReferenceForm, WorkTypeID, client);
            work.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
