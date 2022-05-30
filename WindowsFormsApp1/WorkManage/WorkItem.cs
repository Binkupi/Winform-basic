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

//namespace WindowsFormsApp1.WorkManage
namespace WindowsFormsApp1

{
    public partial class workItem : UserControl
    {
        private WorkManagePage ReferenceForm;
        public workItem()
        {
            InitializeComponent();
        }

        public workItem(WorkManagePage form1)
        {
            InitializeComponent();
            this.ReferenceForm = form1;
        }

        private void WorkItem_Load(object sender, EventArgs e)
        {

        }
        public string strName
        {
            get => txtName.Text;
            set
            {
                // trim if title is too long
                string txt = string.Copy(value);
                if (txt.Length != 0)
                {
                    int i = txt.Length;
                    while (TextRenderer.MeasureText(txt + "...", txtName.Font).Width > txtName.Width - 6)
                    {
                        txt = value.Substring(0, --i);
                        if (i == 0) break;
                    }
                    txtName.Text = txt + "...";
                }
                else
                {
                    txtName.Text = value;
                }
            }
        }

        public string WorkId { get; set; }

        public string strDate
        {
            get => txtDate.Text;
            set
            {
                txtDate.Text = value;
            }

        }
        public string strTime
        {
            get => txtTime.Text;
            set
            {
                txtTime.Text = value;
            }

        }
        public Color gbColor
        {
            get => background.BackColor;
            set
            {
                background.BackColor = value;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                WorkDao workDao = new WorkDao();
                workDao.delete(WorkId);
                ReferenceForm.loadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn sửa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                AddWork addWork = new AddWork(WorkId, this.ReferenceForm);
                addWork.Show();
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(WorkId, this.ReferenceForm, true);
            addWork.Show();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(WorkId, this.ReferenceForm, true);
            addWork.Show();
        }

    }
}
