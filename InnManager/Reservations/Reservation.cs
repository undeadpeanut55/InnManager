using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Reservations
{
    /// <summary>
    /// A reservation made at a hotel
    /// </summary>
    public class Reservation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// An auto generated number used to uniquely identify a reservation
        /// </summary>
        public string ReservationNumber
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReservationNumber)));
            }
        } = string.Empty;

        /// <summary>
        /// The name of the guest who made the reservation
        /// </summary>
        public string GuestName
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GuestName)));
            }
        } = string.Empty;

        /// <summary>
        /// The room number that is reserved
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
        /// The check in date for the reservation
        /// </summary>
        public DateTime CheckInDate
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CheckInDate)));
            }
        } = DateTime.Now;

        /// <summary>
        /// The check out date for the reservation
        /// </summary>
        public DateTime CheckOutDate
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CheckOutDate)));
            }
        } = DateTime.Now;

        /// <summary>
        /// If the reservation has been confirmed
        /// </summary>
        public bool IsConfirmed
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsConfirmed)));
            }
        } = false;

        /// <summary>
        /// If the reservation has been checked out
        /// </summary>
        public bool IsCheckedOut
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCheckedOut)));
            }
        } = false;

        /// <summary>
        /// If the reservation was overdue at checkout
        /// </summary>
        public bool IsCheckedOutOverdue
        {
            get
            {
                if(!IsCheckedOut && (DateTime.Now.Date > CheckOutDate.Date))
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// If the reservation is active
        /// </summary>
        public bool IsActive
        {
            get
            {
                return (IsConfirmed && !IsCheckedOut);
            }
        }

        /// <summary>
        /// The status of the reservation
        /// </summary>
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
