using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScheduleManagement
{
    // The ScheduleTask object, an individual task
    internal class ScheduleTask
    {
        private int id;
        private string taskName;
        private string taskLocation;
        private DateTime taskDate;

        // Constructor for ScheduleTask, ensures form
        // data must be passed in to create
        public ScheduleTask(string TaskName, string TaskLocation, DateTime TaskDate)
        {
            taskName = TaskName;
            taskLocation = TaskLocation;
            taskDate = TaskDate;
        }

        // ID of a task, used to separate
        // possibly identical tasks
        [Key]
        public int Id { get; set; }

        // The properties below are assigned
        // by the constructor

        // Name of an individual Task
        public string TaskName { get => taskName; set => taskName = value; }

        // The location of the Task
        public string TaskLocation { get => taskLocation; set => taskLocation = value; }

        // The date associated with the Task
        public DateTime TaskDate { get => taskDate; set => taskDate = value; }

    }
}
