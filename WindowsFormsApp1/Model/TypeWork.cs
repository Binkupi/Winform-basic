using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class TypeWork
    {
        TypeWork()
        {

        }

        TypeWork(string nameTypeWork, string description, string backgroundColor)
        {
            NameTypeWork = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }
        TypeWork(string idTypeWork, string nameTypeWork, string description, string backgroundColor)
        {
            IdTypeWork = idTypeWork;
            NameTypeWork = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }

        public string IdTypeWork { get; set; }
        public string NameTypeWork { get; set; }
        public string Description { get; set; }
        string BackgroundColor { get; set; }
    }
}
