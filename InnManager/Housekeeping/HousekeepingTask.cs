using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// A housekeeping task that is performed at a hotel
    /// </summary>
    public class HousekeepingTask
    {
        /// <summary>
        /// The room number the task was assigned
        /// </summary>
        public string RoomNumber { get; set; } = string.Empty;

        /// <summary>
        /// A description of the task
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// When the task was/is scheduled
        /// </summary>
        public DateTime ScheduledDate { get; set; } = DateTime.Now;

        /// <summary>
        /// If the task was completed
        /// </summary>
        public bool IsCompleted { get; set; } = false;

        /// <summary>
        /// The current status of the task
        /// </summary>
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
