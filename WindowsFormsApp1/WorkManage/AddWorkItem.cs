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

namespace WindowsFormsApp1
{
    public partial class AddWorkItem : UserControl
    {
        public WorkManagePage workReferenceForm;
        public WorkTypeManagePage workTypeReferenceForm;
        public Home homeReferenceForm;
        public ClientModel client;
        public AddWorkItem()
        {
            InitializeComponent();
        }
        public AddWorkItem(Home form1, WorkManagePage form2, ClientModel client)
        {
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.workReferenceForm = form2;
            this.client = client;
        }
        public AddWorkItem(Home form1, WorkTypeManagePage form2, WorkManagePage form3, ClientModel client)
        {
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.workTypeReferenceForm = form2;
            this.workReferenceForm = form3;
            this.client = client;
        }

        //public AddWorkItem(Home form1)
        //{
        //    InitializeComponent();
        //    this.homeReferenceForm = form1;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, this.workReferenceForm, client);
            addWork.Show();
        }

        private void AddWorkItem_Load(object sender, EventArgs e)
        {

        }

        private void panelAdd_Click(object sender, EventArgs e)
        {
            //AddWork addWork = new AddWork(referenceForm);
            //addWork.Show();
        }
    }
}
