﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.WorkTypeManage
{
    public partial class WorkTypeAdd : UserControl
    {
        public WorkTypeManagePage workTypereferenceForm;
        public WorkTypeAdd()
        {
            InitializeComponent();
        }
        public WorkTypeAdd(WorkTypeManagePage form1)
        {
            InitializeComponent();
            this.workTypereferenceForm = form1;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {


            AddTypeWork addTypeWork = new AddTypeWork(this.workTypereferenceForm);
            addTypeWork.Show();
        }
    }
}
