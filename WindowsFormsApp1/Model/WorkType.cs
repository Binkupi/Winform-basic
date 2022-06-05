using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class WorkType
    {


        public WorkType()
        {

        }

        public WorkType(string nameTypeWork, string description, string backgroundColor)
        {
            Name = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }
        public WorkType(int idTypeWork, string nameTypeWork, string description, string backgroundColor)
        {
            Id = idTypeWork;
            Name = nameTypeWork;
            Description = description;
            BackgroundColor = backgroundColor;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackgroundColor { get; set; }
    }
}
