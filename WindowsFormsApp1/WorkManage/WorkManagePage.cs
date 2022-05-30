using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class WorkManagePage : Form
    {
        private Point? _mouseLocation;
        private WorkDao workDao = new WorkDao();
        public WorkManagePage()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            try
            {
                DataTable lstWork = new DataTable();
                lstWork = workDao.getListWork();
                lstWork = workDao.getListWorkByWorkType("test");
                DateTime today = DateTime.Now;
                var drUndoneWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 0 && today.CompareTo(item.Field<DateTime>("Deadline")) == -1);
                var drDoneWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 1);
                var drLatedWork = lstWork.AsEnumerable().Where(item => item.Field<int>("IsFinished") == 0 && today.CompareTo(item.Field<DateTime>("Deadline")) == 1);
                List<Work> lstUndoneWork = new List<Work>();
                List<Work> lstDoneWork = new List<Work>();
                List<Work> lstLatedWork = new List<Work>();
                if (drUndoneWork.Any())
                {
                    lstUndoneWork = Helper.Helper.ConvertToList<Work>(drUndoneWork.CopyToDataTable());
                }
                if (drDoneWork.Any())
                {
                    DataTable test = drDoneWork.CopyToDataTable();
                    lstDoneWork = Helper.Helper.ConvertToList<Work>(test);
                }
                if (drLatedWork.Any())
                {
                    lstLatedWork = Helper.Helper.ConvertToList<Work>(drLatedWork.CopyToDataTable());
                }
                undoneWorkLayout.Controls.Clear();
                var listUndoneItems = new workItem[100];
                int i = 0;
                foreach (Work undoneWork in lstUndoneWork)
                {
                    listUndoneItems[i] = new workItem(this);
                    listUndoneItems[i].WorkId = undoneWork.Id;
                    listUndoneItems[i].strName = undoneWork.Name;
                    listUndoneItems[i].strDate = undoneWork.Deadline.ToString("dd/MM/yyyy");
                    listUndoneItems[i].strTime = undoneWork.Deadline.ToString("HH: mm");
                    listUndoneItems[i].gbColor = System.Drawing.ColorTranslator.FromHtml(undoneWork.BackgroundColor);


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
                    listDoneItems[i].WorkId = doneWork.Id;
                    listDoneItems[i].strName = doneWork.Name;
                    listDoneItems[i].strDate = doneWork.Deadline.ToString("dd/MM/yyyy");
                    listDoneItems[i].strTime = doneWork.Deadline.ToString("HH: mm");
                    listDoneItems[i].Margin = new Padding(10);
                    doneWorkLayout.Controls.Add(listDoneItems[i]);
                    i++;
                }
                latedWorkLayout.Controls.Clear();
                AddWorkItem addUndoneItem = new AddWorkItem(this);
                var listLatedItems = new workItem[100];
                i = 0;
                foreach (Work latedWork in lstLatedWork)
                {
                    listLatedItems[i] = new workItem();
                    listLatedItems[i].WorkId = latedWork.Id;
                    listLatedItems[i].strName = latedWork.Name;
                    listLatedItems[i].strDate = latedWork.Deadline.ToString("dd/MM/yyyy");
                    listLatedItems[i].strTime = latedWork.Deadline.ToString("HH: mm");
                    listLatedItems[i].Margin = new Padding(10);
                    latedWorkLayout.Controls.Add(listLatedItems[i]);
                    i++;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void undoneWorkLayout_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void undoneWorkLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._mouseLocation.HasValue)
            {
                MessageBox.Show(this._mouseLocation.Value.X.ToString());
                this.undoneWorkLayout.Left = e.X + this.undoneWorkLayout.Left - this._mouseLocation.Value.X;
                this.undoneWorkLayout.Top = e.Y + this.undoneWorkLayout.Top - this._mouseLocation.Value.Y;
            }
        }

        private void undoneWorkLayout_MouseUp(object sender, MouseEventArgs e)
        {

            this._mouseLocation = null;

        }

        private void undoneWorkLayout_DragEnter(object sender, DragEventArgs e)
        {
            //if (this._mouseLocation.HasValue)
            //{
            //    MessageBox.Show(this._mouseLocation.Value.X.ToString());
            //    this.undoneWorkLayout.Left = e.X + this.undoneWorkLayout.Left - this._mouseLocation.Value.X;
            //    this.undoneWorkLayout.Top = e.Y + this.undoneWorkLayout.Top - this._mouseLocation.Value.Y;
            //}
        }

        private void undoneWorkLayout_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void undoneWorkLayout_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("có2");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {   
            
            DataTable dtWork = new DataTable("Work");
            Helper.Helper.ImportExcel(ref dtWork);

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataTable dtWork = new DataTable("Work");
            dtWork.Columns.Add("Loại công việc", typeof(string));
            dtWork.Columns.Add("Tên công việc", typeof(string));
            DataRow row = dtWork.NewRow();
            row["Loại công việc"] = "1";
            row["Tên công việc"] = "Quoooooooc";
            dtWork.Rows.Add(row);
            Helper.Helper.ExportExcel(dtWork);
        }

        private void btnDefaultExport_Click(object sender, EventArgs e)
        {
            DataTable dtWork = new DataTable("Work");
            dtWork.Columns.Add("Loại công việc", typeof(string));
            dtWork.Columns.Add("Tên công việc", typeof(string));
            DataRow row = dtWork.NewRow();
            row["Loại công việc"] = "1";
            row["Tên công việc"] = "Quoooooooc";
            Helper.Helper.ExportDefaultExcel(dtWork);
        }

        private void WorkManagePage_Resize(object sender, EventArgs e)
        {
            //int formHeight = this.ClientSize.Height;
            //int formWidth = this.ClientSize.Width;
            //panelUndoneWork.Size = new Size(formWidth / 2 - 10, formHeight / 2);
            //panelUndoneWork.Location = new Point(5, 0);
            ////panelDoneWork.Margin = new Padding(10);
            //panelDoneWork.Size = new Size(formWidth / 2 - 10, formHeight / 2);
            //panelDoneWork.Location = new Point((formWidth / 2) + 5, 0);
            //panelLatedWork.Size = new Size(formWidth - 10, formHeight / 2);
            //panelLatedWork.Location = new Point(5, formHeight / 2);
            ////panelUndoneWork.Size = new Size(formWidth -10, formHeight /2-10);
        }

        private void WorkManagePage_SizeChanged(object sender, EventArgs e)
        {
            panelUndoneWork.Size = new Size((panelUndoneWork.Parent.Width/ 2)-10, (panelUndoneWork.Parent.Height / 2) - 10);
            panelUndoneWork.Location = new Point(0,0);
            panelTool.Location = new Point(panelTool.Parent.Width- panelTool.Width-5, 0);
            panelDoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 2) - 10);
            panelDoneWork.Location = new Point((panelUndoneWork.Parent.Width / 2) +5, 0);
            panelLatedWork.Size = new Size((panelUndoneWork.Parent.Width) - 10, (panelUndoneWork.Parent.Height / 2) - 10);
            panelLatedWork.Location = new Point(0,((panelUndoneWork.Parent.Height / 2) + 5));
            titleLatedWork.Location = new Point((titleLatedWork.Parent.Width - titleLatedWork.Width) / 2, 10);
        }

        private void WorkManagePage_Load(object sender, EventArgs e)
        {
            panelUndoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 2) - 10);
            panelUndoneWork.Location = new Point(0, 0);
            panelTool.Location = new Point(panelTool.Parent.Width - panelTool.Width-5, 0);
            panelDoneWork.Size = new Size((panelUndoneWork.Parent.Width / 2) - 10, (panelUndoneWork.Parent.Height / 2) - 10);
            panelDoneWork.Location = new Point((panelUndoneWork.Parent.Width / 2) + 5, 0);
            panelLatedWork.Size = new Size((panelUndoneWork.Parent.Width ) - 10, (panelUndoneWork.Parent.Height / 2) - 10);
            panelLatedWork.Location = new Point(0,( (panelUndoneWork.Parent.Height / 2) + 5));
            titleLatedWork.Location = new Point((titleLatedWork.Parent.Width - titleLatedWork.Width) / 2, 10);
        }
    }
}
