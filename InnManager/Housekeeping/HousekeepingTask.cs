using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Housekeeping
{
    /// <summary>
    /// A housekeeping task that is performed at a hotel
    /// </summary>
    public class HousekeepingTask : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The hotel staff assigned to the task
        /// </summary>
        public string AssignedStaff
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AssignedStaff)));
            }
        } = string.Empty;

        /// <summary>
        /// The room number the task was assigned
        /// </summary>
        public string RoomNumber
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoomNumber)));
            }
        } = string.Empty;

        /// <summary>
        /// A description of the task
        /// </summary>
        public string Description
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        } = string.Empty;

        /// <summary>
        /// When the task was/is scheduled
        /// </summary>
        public DateTime ScheduledDate
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ScheduledDate)));
            }
        } = DateTime.Now;

        /// <summary>
        /// If the task was completed
        /// </summary>
        public bool IsCompleted
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCompleted)));
            }
        } = false;

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
