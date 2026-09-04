using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    public class HousekeepingTask
    {

        public string RoomNumber { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime ScheduledDate { get; set; } = DateTime.Now;

        public bool IsCompleted { get; set; } = false;

        public string Status
        {
            get
            {
                if (IsCompleted) return "Completed";
                return "Not Completed";
            }
        }


    }
}
