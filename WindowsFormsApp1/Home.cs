using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {

            undoneWorkLayout.Controls.Clear();
            workItem workItem1 = new workItem();
            workItem workItem2 = new workItem();
            workItem workItem3 = new workItem();
            workItem workItem4 = new workItem();
            AddWorkItem addItem = new AddWorkItem();
            undoneWorkLayout.Controls.Add(workItem1);
            undoneWorkLayout.Controls.Add(workItem2);
            undoneWorkLayout.Controls.Add(workItem3);
            doneWorkLayout.Controls.Clear();
            doneWorkLayout.Controls.Add(workItem4);





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            panelUndoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 1) - 10);
            panelUndoneWork.Location = new Point(0, 0);
            //panelTool.Location = new Point(panelTool.Parent.Width - panelTool.Width - 5, 0);
            panelDoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 1) - 10);
            panelDoneWork.Location = new Point((panelUndoneWork.Parent.Width / 2) + 5, 0);

        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            panelUndoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 1) - 10);
            panelUndoneWork.Location = new Point(0, 0);
            //panelTool.Location = new Point(panelTool.Parent.Width - panelTool.Width - 5, 0);
            panelDoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 1) - 10);
            panelDoneWork.Location = new Point((panelUndoneWork.Parent.Width / 2) + 5, 0);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUndoneWork_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_ListWork_DoubleClick(object sender, EventArgs e)
        {
            WorkManagePage workManagePage = new WorkManagePage();
            workManagePage.Show();
        }

        private void lbl_ListTypeWork_DoubleClick(object sender, EventArgs e)
        {
            WorkTypeManagePage workTypeManagePage = new WorkTypeManagePage();
            workTypeManagePage.Show();
        }
    }
}
