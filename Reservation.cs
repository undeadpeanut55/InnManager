using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    public class Reservation
    {

        public string GuestName { get; set; } = string.Empty;

        public string RoomNumber { get; set; } = string.Empty;

        public DateTime CheckInDate { get; set; } = DateTime.Now;

        public DateTime CheckOutDate { get; set; } = DateTime.Now;

        public bool IsConfirmed { get; set; } = false;

        public bool IsCheckedOut { get; set; } = false;

        public bool IsCheckedOutOverdue
        {
            get
            {
                if(IsCheckedOut && (DateTime.Now > CheckOutDate))
                {
                    return true;
                }
                return false;
            }
        }

        public bool IsActive
        {
            get
            {
                return (IsConfirmed && !IsCheckedOut);
            }
        }

        public string Status
        {
            get
            {
                if (IsCheckedOutOverdue) { return "Overdue"; }
                if (IsCheckedOut) { return "Checked Out"; }
                if (IsConfirmed) { return "Confirmed"; }
                return "Pending";
            }
        }
    }
}
