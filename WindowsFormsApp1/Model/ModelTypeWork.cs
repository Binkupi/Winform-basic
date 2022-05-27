using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class ModelTypeWork
    {


        public ModelTypeWork()
        {

        }

        public ModelTypeWork(string nameTypeWork, string description, string backgroundColor)
        {
            Name = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }
        public ModelTypeWork(string idTypeWork, string nameTypeWork, string description, string backgroundColor)
        {
            Id = idTypeWork;
            Name = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }


        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackgroundColor { get; set; }
    }
}
