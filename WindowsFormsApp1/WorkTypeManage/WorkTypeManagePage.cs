using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.WorkManage;
using WindowsFormsApp1.WorkTypeManage;

namespace WindowsFormsApp1
{
    public partial class WorkTypeManagePage : Form
    {
        public WorkTypeManagePage()
        {
            InitializeComponent();
            LoadList();
        }
        private void LoadList()
        {
            flPanel_layout.Controls.Clear();
            var listItems = new TypeWork[100];
            int i = 0;
            //foreach (Product product in ProductList)
            //{
            listItems[i] = new TypeWork();
            listItems[i].WorkTypeName = "test1";
            listItems[i].WorkTypeDescription = "mô tả 1";
            listItems[i].Margin = new Padding(30);
            listItems[i].Click += new System.EventHandler(this.item_Clicked);
            flPanel_layout.Controls.Add(listItems[i]);
            i = 1;
            listItems[i] = new TypeWork();
            listItems[i].WorkTypeName = "test1";
            listItems[i].WorkTypeDescription = "mô tả 1";
            listItems[i].Margin = new Padding(30);
            listItems[i].Click += new System.EventHandler(this.item_Clicked);
            flPanel_layout.Controls.Add(listItems[i]);
            i = 3;
            listItems[i] = new TypeWork();
            listItems[i].WorkTypeName = "test1";
            listItems[i].WorkTypeDescription = "mô tả 1";
            listItems[i].Margin = new Padding(30);
            listItems[i].Click += new System.EventHandler(this.item_Clicked);
            flPanel_layout.Controls.Add(listItems[i]);
            i = 4;
            listItems[i] = new TypeWork();
            listItems[i].WorkTypeName = "test1";
            listItems[i].WorkTypeDescription = "mô tả 1";
            listItems[i].Margin = new Padding(30);
            listItems[i].Click += new System.EventHandler(this.item_Clicked);
            flPanel_layout.Controls.Add(listItems[i]);
            i = 5;
            listItems[i] = new TypeWork();
            listItems[i].WorkTypeName = "test1";
            listItems[i].WorkTypeDescription = "mô tả 1";

            listItems[i].Click += new System.EventHandler(this.item_Clicked);
            flPanel_layout.Controls.Add(listItems[i]);
            var data = new WorkTypeAdd();
            data.Margin = new Padding(30);
            data.Click += new System.EventHandler(this.item_Add);
            flPanel_layout.Controls.Add(data);
            //}
        }

        private void item_Clicked(object sender, EventArgs e)
        {
            var item = (TypeWork)sender;
            var selectProduct = new TypeWork();
           
        }
        private void item_Add(object sender, EventArgs e)
        {
            var item = (AddWorkItem)sender;
            MessageBox.Show("Add");
        }

        private void WorkTypeManage_Load(object sender, EventArgs e)
        {

        }
    }
}
