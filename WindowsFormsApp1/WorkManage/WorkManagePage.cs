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

namespace WindowsFormsApp1
{
    public partial class WorkManagePage : Form
    {
        private Point? _mouseLocation;
        public WorkManagePage()
        {
            InitializeComponent();
            loadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadData()
        {
            undoneWorkLayout.Controls.Clear();
            workItem workItem = new workItem();
            workItem workItem2 = new workItem();
            workItem workItem3 = new workItem();
            workItem workItem4 = new workItem();
            AddWorkItem addItem = new AddWorkItem();
            undoneWorkLayout.Controls.Add(workItem);
            undoneWorkLayout.Controls.Add(workItem2);
            undoneWorkLayout.Controls.Add(addItem);
            doneWorkLayout.Controls.Clear();
            doneWorkLayout.Controls.Add(workItem3);
            latedWorkLayout.Controls.Clear();
            latedWorkLayout.Controls.Add(workItem4);
        }

        private void undoneWorkLayout_MouseDown(object sender, MouseEventArgs e)
        {
            //var control = sender as Control;
            //this.DoDragDrop(control.Name, DragDropEffects.Move);
            //this._mouseLocation = e.Location;
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
            MessageBox.Show("có");
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
