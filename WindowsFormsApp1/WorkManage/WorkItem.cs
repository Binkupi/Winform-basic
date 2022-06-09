using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

//namespace WindowsFormsApp1.WorkManage
namespace WindowsFormsApp1
{
   
    public partial class workItem : UserControl
    {

        public WorkManagePage workReferenceForm;
        public Home homeReferenceForm;
        public WorkTypeManagePage workTypeReferenceForm;
        private string inputIdWorkType;
        public int stateNotification;
        private string workId;
        WorkDao workDao = new WorkDao();
        DataTable data = new DataTable();
        //private string message;

        //public workItem()
        //{
        //    InitializeComponent();
        //}

        //public workItem(WorkManagePage form1,string idWorkType)
        //{
        //    InitializeComponent();
        //    inputIdWorkType = idWorkType;
        //    this.ReferenceForm = form1;
        //}

        public workItem(Home form1, WorkTypeManagePage form2, WorkManagePage form3, string idWorkType,ClientModel client)
        {
           
            InitializeComponent();
            
            loadData();
            inputIdWorkType = idWorkType;
            this.homeReferenceForm = form1;
            this.workTypeReferenceForm = form2;
            this.workReferenceForm = form3;
            this.client = client;
        }
        public workItem(Home form1, WorkTypeManagePage form2, WorkManagePage form3, string idWorkType, string workId,  int isNotification, ClientModel client)
        {
           
            InitializeComponent();
            this.stateNotification = isNotification;
            this.workId = workId;
            this.client = client;


            loadData();
            inputIdWorkType = idWorkType;
           
            this.homeReferenceForm = form1;
            this.workTypeReferenceForm = form2;
            this.workReferenceForm = form3;
           
            
        }


        public workItem(Home form1,ClientModel client)
        {
            
            InitializeComponent();
            loadData();
            this.homeReferenceForm = form1;
            this.client = client;
           
        }
        public workItem(Home form1, string workId, int isNotification, ClientModel client)
        {
            
            InitializeComponent();
            this.stateNotification = isNotification;
            this.workId = workId;
            this.client = client;
            this.homeReferenceForm = form1;
            loadData();
           

        }

        private void WorkItem_Load(object sender, EventArgs e)
        {

        }
        public string strName
        {
            get => txtName.Text;
            set
            {
                //    // trim if title is too long
                //    string txt = string.Copy(value);
                //    if (txt.Length != 0)
                //    {
                //        int i = txt.Length;
                //        while (TextRenderer.MeasureText(txt, txtName.Font).Width > txtName.Width - 6)
                //        {
                //            txt = value.Substring(0, --i);
                //            if (i == 0) break;
                //        }
                //        txtName.Text = txt;
                //    }
                //    else
                //    {
                //        txtName.Text = value;
                //    }
                txtName.Text = value;
        }
        }
        public string WorkType { get; set; }

        public ClientModel client { get; set; }

        public string WorkId { get; set; }

        public string strDate
        {
            get => txtDate.Text;
            set
            {
                txtDate.Text = value;
            }

        }
        public string strTime
        {
            get => txtTime.Text;
            set
            {
                txtTime.Text = value;
            }

        }
        
        public Color gbColor
        {
            get => background.BackColor;
            set
            {
                background.BackColor = value;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn xóa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                WorkDao workDao = new WorkDao();
                string idWorkType = WorkType;
                workDao.delete(WorkId, client);
                //ReferenceForm.loadData(WorkType);
                
                if(this.workReferenceForm != null)
                {
                    workReferenceForm.loadData(inputIdWorkType);
                    workTypeReferenceForm.loadData();
                    
                }
                this.homeReferenceForm.loadData();
                     
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn sửa công việc này không?";
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //AddWork addWork = new AddWork(WorkId, this.ReferenceForm, false);
                //addWork.Show();

                AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, WorkId, this.workReferenceForm,client, false);
                addWork.Show();

               
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {

            AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, WorkId, this.workReferenceForm,client, true);
            addWork.Show();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            AddWork addWork = new AddWork(this.homeReferenceForm, this.workTypeReferenceForm, WorkId, this.workReferenceForm,client, true);
            addWork.Show();
        }

        public void loadData()
        {
           
           
            if (this.stateNotification == 1)
            {
                ptbNotificationBell.Image = Properties.Resources.bell_on;
            } else
            {
                ptbNotificationBell.Image = Properties.Resources.bell_off;
            }
        }

        private void ptbNotificationBell_Click(object sender, EventArgs e)
        {
            loadData();

             string message;
            if (this.stateNotification == 0)
            {
                message = "Bạn muốn bật thông báo công việc này?";
            } else
            {
                 message = "Bạn muốn tắt thông báo công việc này?";
            }
            string title = "Thông báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //WorkDao workDao = new WorkDao();
                //string idWorkType = WorkType;
                // workDao.delete(WorkId);

                //ReferenceForm.loadData(WorkType);


                this.data = this.workDao.getWorkByWorkID(this.workId, client);
                int isNotification;

                if (this.stateNotification == 1)
                {
                    isNotification = 0;
                    loadData();
                }
                else
                {
                    //this.stateNotification = 1;
                    isNotification = 1 ;
                }

               // bool checkNotification;
                bool checkFinish;


                string workName = data.Rows[0]["name"].ToString();
                string Description = data.Rows[0]["description"].ToString();
                string idTypeWork = data.Rows[0]["workType"].ToString();



                
                DateTime deadline = DateTime.Parse(data.Rows[0]["Deadline"].ToString());
                DateTime alrmDate = DateTime.Parse(data.Rows[0]["alarmDate"].ToString());


                checkFinish = int.Parse(data.Rows[0]["isFinished"].ToString()) == 1 ? true : false;
                int inFinish = checkFinish ? 1 : 0;

                Work work = new Work(Int32.Parse(this.WorkId),workName, idTypeWork, isNotification, deadline, Description, alrmDate, inFinish);
                workDao.update(work,client);
                loadData();

                if (this.workReferenceForm != null)
                {
                    workReferenceForm.loadData(inputIdWorkType);
                }
                this.homeReferenceForm.loadData();

            }
        }
    }
}
