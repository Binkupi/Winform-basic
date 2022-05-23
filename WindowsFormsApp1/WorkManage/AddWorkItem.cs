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
        public AddWorkItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork();
            addWork.Show();
        }

        private void AddWorkItem_Load(object sender, EventArgs e)
        {

        }
    }
}
