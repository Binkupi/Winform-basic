using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Work
    {
        Work()
        {

        }

        Work(string idWork, string name, string idWorkType, DateTime startDate, DateTime deadline, string description, string backgroundColor, int isFinished)
        {
            IdWork = idWork;
            Name = name;
            IdWorkType = idWorkType;
            StartDate = startDate;
            Deadline = deadline;
            Description = description;
            BackgroundColor = backgroundColor;
            IsFinished = isFinished;

        }

        public string IdWork { get; set; }
        public string Name { get; set; }
        public string IdWorkType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public string BackgroundColor { get; set; }
        public int IsFinished { get; set; }
    }
}
