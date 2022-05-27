using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Work
    {
        public Work()
        {

        }

        public Work(string id, string name, string idWorkType, DateTime startDate, DateTime deadline, string description, string backgroundColor, int isFinished)
        {
            Id = id;
            Name = name;
            WorkType = idWorkType;
            StartDate = startDate;
            Deadline = deadline;
            Description = description;
            BackgroundColor = backgroundColor;
            IsFinished = isFinished;

        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string WorkType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public string BackgroundColor { get; set; }
        public int IsFinished { get; set; }
    }
}
