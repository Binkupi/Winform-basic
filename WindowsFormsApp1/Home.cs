using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        private WorkDao workDao = new WorkDao();
        public Home()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            try
            {
                DataTable lstWork = new DataTable();
                DateTimePicker today = new DateTimePicker();
                today.Value = DateTime.Now;
                String txtToday = today.Value.ToString("yyyy-MM-dd");
                Console.WriteLine(txtToday);


                // string query = "SELECT * FROM work where deadline LIKE '" + txtToday + "%'";
                //MessageBox.Show(query);

                lstWork = workDao.getAllWorkByDate(txtToday);

                //DateTime today = DateTime.Now;
                var drUndoneWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 0);
                var drDoneWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 1);
               
                List<Work> lstUndoneWork = new List<Work>();
                List<Work> lstDoneWork = new List<Work>();
               
                if (drUndoneWork.Any())
                {
                    lstUndoneWork = Helper.Helper.ConvertToList<Work>(drUndoneWork.CopyToDataTable());
                }
                if (drDoneWork.Any())
                {
                    DataTable test = drDoneWork.CopyToDataTable();
                    lstDoneWork = Helper.Helper.ConvertToList<Work>(test);
                }
              
                undoneWorkLayout.Controls.Clear();
                var listUndoneItems = new workItem[100];
                int i = 0;
                foreach (Work undoneWork in lstUndoneWork)
                {
                    listUndoneItems[i] = new workItem(this);
                    listUndoneItems[i].WorkId = undoneWork.Id.ToString();
                    listUndoneItems[i].WorkType = undoneWork.WorkType;
                    listUndoneItems[i].strName = undoneWork.Name;
                    listUndoneItems[i].strDate = undoneWork.Deadline.ToString("dd/MM/yyyy");
                    //listUndoneItems[i].strTime = undoneWork.Deadline.ToString("HH: mm");

                    //listUndoneItems[i].gbColor = System.Drawing.ColorTranslator.FromHtml(undoneWork.BackgroundColor);


                    listUndoneItems[i].Margin = new Padding(10);
                    undoneWorkLayout.Controls.Add(listUndoneItems[i]);
                    i++;
                }
                AddWorkItem addWorkItem = new AddWorkItem(this);
                addWorkItem.Margin = new Padding(10);
                undoneWorkLayout.Controls.Add(addWorkItem);


                doneWorkLayout.Controls.Clear();
                var listDoneItems = new workItem[100];
                i = 0;
                foreach (Work doneWork in lstDoneWork)
                {
                    listDoneItems[i] = new workItem(this);
                    listDoneItems[i].WorkId = doneWork.Id.ToString();
                    listDoneItems[i].strName = doneWork.Name;
                    listDoneItems[i].strDate = doneWork.Deadline.ToString("dd/MM/yyyy");
                    listDoneItems[i].strTime = doneWork.Deadline.ToString("HH: mm");
                    listDoneItems[i].Margin = new Padding(10);
                    doneWorkLayout.Controls.Add(listDoneItems[i]);
                    i++;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //undoneWorkLayout.Controls.Clear();
            //workItem workItem1 = new workItem();
            //workItem workItem2 = new workItem();
            //workItem workItem3 = new workItem();
            //workItem workItem4 = new workItem();
            //AddWorkItem addItem = new AddWorkItem();
            //undoneWorkLayout.Controls.Add(workItem1);
            //undoneWorkLayout.Controls.Add(workItem2);
            //undoneWorkLayout.Controls.Add(workItem3);
            //doneWorkLayout.Controls.Clear();
            //doneWorkLayout.Controls.Add(workItem4);





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
            //WorkManagePage workManagePage = new WorkManagePage();
            //workManagePage.Show();
        }

        private void lbl_ListTypeWork_DoubleClick(object sender, EventArgs e)
        {
            WorkTypeManagePage workTypeManagePage = new WorkTypeManagePage();
            workTypeManagePage.Show();
        }
    }
}
