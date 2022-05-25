using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class ModelTypeWork
    {
        private string idTypeWork;
        private string nameTypeWork;
        private string description;
        private string backgroundColor;


        public ModelTypeWork()
        {

        }

        public ModelTypeWork(string nameTypeWork, string description, string backgroundColor)
        {
            NameTypeWork = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }
        public ModelTypeWork(string idTypeWork, string nameTypeWork, string description, string backgroundColor)
        {
            IdTypeWork = idTypeWork;
            NameTypeWork = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }


        public string IdTypeWork { get => idTypeWork; set => idTypeWork = value; }
        public string NameTypeWork { get => nameTypeWork; set => nameTypeWork = value; }
        public string Description { get => description; set => description = value; }
        public string BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        //public string IdTypeWork { get; set; }
        //public string NameTypeWork { get; set; }
        //public string Description { get; set; }
        //string BackgroundColor { get; set; }
    }
}
