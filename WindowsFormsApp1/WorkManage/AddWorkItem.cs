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
    public partial class AddWorkItem : UserControl
    {
        public WorkManagePage workReferenceForm;
        public WorkTypeManagePage workTypeReferenceForm;
        public Home homeReferenceForm;

        public AddWorkItem()
        {
            InitializeComponent();
        }
        public AddWorkItem(Home form1, WorkManagePage form2)
        {
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.workReferenceForm = form2;
        }
        public AddWorkItem(Home form1, WorkTypeManagePage form2, WorkManagePage form3)
        {
            InitializeComponent();
            this.homeReferenceForm = form1;
            this.workTypeReferenceForm = form2;
            this.workReferenceForm = form3;
        }

        //public AddWorkItem(Home form1)
        //{
        //    InitializeComponent();
        //    this.homeReferenceForm = form1;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, this.workReferenceForm);
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
