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

        public Work(string name, string idWorkType, int isNotification, DateTime deadline, string description, DateTime alarmDate, int isFinished)
        {
            
            Name = name;
            WorkType = idWorkType;
            IsNotification = isNotification;
            Deadline = deadline;
            Description = description;
            AlarmDate = alarmDate;
            IsFinished = isFinished;

        }
        public Work(int id, string name, string idWorkType, int isNotification, DateTime deadline, string description, DateTime alarmDate, int isFinished)
        {
            Id = id;
            Name = name;
            WorkType = idWorkType;
            IsNotification = isNotification;
            Deadline = deadline;
            Description = description;
            AlarmDate = alarmDate;
            IsFinished = isFinished;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkType { get; set; }
        public int IsNotification { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public DateTime AlarmDate { get; set; }
        public int IsFinished { get; set; }
    }
}
