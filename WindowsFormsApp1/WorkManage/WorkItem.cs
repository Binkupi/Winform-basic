using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace WindowsFormsApp1.WorkManage
namespace WindowsFormsApp1

{
    public partial class workItem : UserControl
    {
        public workItem()
        {
            InitializeComponent();
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
                if (strName.Length != 0)
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(WorkId, true );
            addWork.Show();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(WorkId);
            addWork.Show();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(WorkId);
            addWork.Show();
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {

        }
        //public string Inventory
        //{
        //    get => txtInventory.Text;
        //    set
        //    {
        //        txtInventory.Text = value;
        //    }
        //}

    }
}
