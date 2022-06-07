using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.WorkTypeManage
{
    public partial class WorkTypeAdd : UserControl
    {
        public WorkTypeManagePage workTypereferenceForm;
        private ClientModel client;
        public WorkTypeAdd()
        {
            InitializeComponent();
        }
        public WorkTypeAdd(WorkTypeManagePage form1, ClientModel client)
        {
            InitializeComponent();
            this.workTypereferenceForm = form1;
            this.client = client;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddTypeWork addTypeWork = new AddTypeWork(this.workTypereferenceForm, client);
            addTypeWork.Show();
        }
    }
}
