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
    public partial class TypeWork : UserControl
    {
        public TypeWork()
        {
            InitializeComponent();
        }

        private void TypeWork_Load(object sender, EventArgs e)
        {

        }
        public string WorkTypeName
        {
            get => txtWorkTypeName.Text;
            set
            {
                // trim if title is too long
                string txt = string.Copy(value);
                if (WorkTypeName.Length != 0)
                {
                    int i = txt.Length;
                    while (TextRenderer.MeasureText(txt + "...", txtWorkTypeName.Font).Width > txtWorkTypeName.Width - 6)
                    {
                        txt = value.Substring(0, --i);
                        if (i == 0) break;
                    }
                    txtWorkTypeName.Text = txt + "...";
                }
                else
                {
                    txtWorkTypeName.Text = value;
                }
            }
        }

        public string Work { get; set; }

        public string WorkTypeDescription
        {
            get => txtWorkTypeDescription.Text;
            set
            {
                txtWorkTypeDescription.Text = value;
            }

        }
        //public string Inventory
        //{
        //    get => txtInventory.Text;
        //    set
        //    {
        //        txtInventory.Text = value;
        //    }
        //}
    }
}
