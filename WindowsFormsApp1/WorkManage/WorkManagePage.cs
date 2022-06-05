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
        private string idWorkType;
        public WorkManagePage(string idWorkType)
        {
            InitializeComponent();
            loadData(idWorkType);
        }

        
        public void loadData(string idWorkType)
        {
            try
            {

                this.idWorkType = idWorkType;
                DataTable lstWork = new DataTable();
                //lstWork = workDao.getListWorkByWorkType("test");
                lstWork = workDao.getListWorkByWorkType(idWorkType);
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
                    listUndoneItems[i].WorkId = undoneWork.Id.ToString();
                    listUndoneItems[i].WorkType = undoneWork.WorkType;
                    listUndoneItems[i].strName = undoneWork.Name;
                    listUndoneItems[i].strDate = undoneWork.Deadline.ToString("dd/MM/yyyy");
                    listUndoneItems[i].strTime = undoneWork.Deadline.ToString("HH: mm");
                   
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
                latedWorkLayout.Controls.Clear();
                AddWorkItem addUndoneItem = new AddWorkItem(this);
                var listLatedItems = new workItem[100];
                i = 0;
                foreach (Work latedWork in lstLatedWork)
                {
                    listLatedItems[i] = new workItem(this);
                    listLatedItems[i].WorkId = latedWork.Id.ToString();
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

        }

        private void undoneWorkLayout_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void undoneWorkLayout_MouseEnter(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable lstWork = new DataTable("WorkExcel");
                Helper.Helper.ImportExcel(ref lstWork);
                DataTable dtWork = new DataTable("Work");
                dtWork.Columns.Add("name", typeof(string));
                dtWork.Columns.Add("workType", typeof(string));
                dtWork.Columns.Add("description", typeof(string));
                dtWork.Columns.Add("deadline", typeof(DateTime));
                dtWork.Columns.Add("isNotification", typeof(int));
                dtWork.Columns.Add("alarmDate", typeof(DateTime));
                dtWork.Columns.Add("isFinished", typeof(int));
                foreach (DataRow row in lstWork.Rows)
                {
                    DataRow rowExel = dtWork.NewRow();
                    rowExel["name"] = row["Tên công việc"].ToString();
                    rowExel["workType"] = row["Mã loại công việc"].ToString();
                    rowExel["description"] = row["Mô tả công việc"].ToString();
                    rowExel["deadline"] = DateTime.ParseExact(row["Ngày kết thúc"].ToString(), "dd/MM/yyyy", null);
                    rowExel["isNotification"] = Int32.Parse(row["Có nhận thông báo"].ToString());
                    rowExel["alarmDate"] = DateTime.ParseExact(row["Ngày thông báo"].ToString(), "dd/MM/yyyy", null);
                    rowExel["isFinished"] = 0;
                    dtWork.Rows.Add(rowExel);
                }
                
                DateTime today = DateTime.Now;
                var drUndoneWork = dtWork.AsEnumerable().Where(item => item.Field<int>("isFinished")==0 && today.CompareTo(item.Field<DateTime>("deadline")) == -1);
                List<Work> lstUndoneWork = new List<Work>();
                if (drUndoneWork.Any())
                {
                    lstUndoneWork = Helper.Helper.ConvertToList<Work>(drUndoneWork.CopyToDataTable());
                }
                foreach (Work work in lstUndoneWork)
                {
                    workDao.insertExcel(work);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DataTable dtWorkExcel = new DataTable("Work");
            dtWorkExcel = workDao.getListWorkByWorkType(idWorkType);
            if(dtWorkExcel!=null && dtWorkExcel.Rows.Count == 0)
            {
                throw new Exception("Không có dữ liệu xuất");
            }
            DataTable dtWork = new DataTable("Work");
            dtWork.Columns.Add("Tên công việc", typeof(string));
            dtWork.Columns.Add("Mã loại công việc", typeof(string));
            dtWork.Columns.Add("Mô tả công việc", typeof(string));
            dtWork.Columns.Add("Ngày kết thúc", typeof(string));
            dtWork.Columns.Add("Có nhận thông báo", typeof(int));
            dtWork.Columns.Add("Ngày thông báo", typeof(string));           
            foreach (DataRow row in dtWorkExcel.Rows)
            {
                
                DataRow rowExel = dtWork.NewRow();
                rowExel["Tên công việc"] = row["name"].ToString();
                rowExel["Mã loại công việc"] = row["workType"].ToString();
                rowExel["Mô tả công việc"] = row["description"].ToString();
                rowExel["Ngày kết thúc"] = DateTime.Parse(row["deadline"].ToString()).ToString("dd/MM/yyyy");
                rowExel["Có nhận thông báo"] = row["isNotification"].ToString();
                rowExel["Ngày thông báo"] = DateTime.Parse(row["alarmDate"].ToString()).ToString("dd/MM/yyyy");
                dtWork.Rows.Add(rowExel);

            }
            Helper.Helper.ExportExcel(dtWork);
        }

        private void btnDefaultExport_Click(object sender, EventArgs e)
        {
            DataTable dtWork = new DataTable("Work");
            dtWork.Columns.Add("Tên công việc", typeof(string));
            dtWork.Columns.Add("Mã loại công việc", typeof(string));
            dtWork.Columns.Add("Mô tả công việc", typeof(string));
            dtWork.Columns.Add("Ngày kết thúc", typeof(string));
            dtWork.Columns.Add("Có nhận thông báo", typeof(int));
            dtWork.Columns.Add("Ngày thông báo", typeof(string));
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

        private void datetimepicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
