using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class WorkCustom
    {
        public WorkCustom()
        {
        }

        public WorkCustom(string workName, string workTypeName)
        {
            this.workName = workName;
            this.workTypeName = workTypeName;
        }

        public string workName { get; set; }
        public string workTypeName { get; set; }

    }
}
