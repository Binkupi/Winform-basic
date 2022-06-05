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
        private WorkManagePage referenceForm;
        private Home HomeReferenceForm;

        public AddWorkItem()
        {
            InitializeComponent();
        }
        public AddWorkItem(WorkManagePage form1)
        {
            InitializeComponent();
            this.referenceForm = form1;
        }

        public AddWorkItem(Home form1)
        {
            InitializeComponent();
            this.HomeReferenceForm = form1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(referenceForm);
            addWork.Show();
        }

        private void AddWorkItem_Load(object sender, EventArgs e)
        {

        }

        private void panelAdd_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(referenceForm);
            addWork.Show();
        }
    }
}
