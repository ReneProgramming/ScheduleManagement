using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ScheduleManagement
{
    // The ScheduleEvent object, an individual event
    internal class ScheduleEvent
    {

        private string eventName;
        private string eventLocation;
        private DateTime eventDate;

        // Constructor for ScheduleEvent, ensures form
        // data must be passed in to create
        public ScheduleEvent(string EventName, string EventLocation, DateTime EventDate)
        {
            eventName = EventName;
            eventLocation = EventLocation;
            eventDate = EventDate;
        }

        // ID of an event, used to separate
        // possibly identical events
        [Key]
        public int Id { get; set; }

        // The properties below are assigned
        // by the constructor

        // Name of an individual Event
        public string EventName { get => eventName; set => eventName = value; }

        // The location of the Event
        public string EventLocation { get => eventLocation; set => eventLocation = value; }

        // The date associated with the Event
        public DateTime EventDate { get => eventDate; set => eventDate = value; }

    }
}
