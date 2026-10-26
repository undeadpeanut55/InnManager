using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Rooms
{
    /// <summary>
    /// Represents a hotel room managed by the InnManager system.
    /// </summary>
    /// <remarks>
    /// The Room class stores identifying information about a hotel room, including its room number, room type, nightly rate and current availability.
    /// </remarks>
    public class Room : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Field used used in the NextId property
        /// </summary>
        private static long _nextID = 0;

        /// <summary>
        /// Gets the next ID number
        /// </summary>
        public static long NextID
        {
            get
            {
                _nextID++;
                return _nextID;
            }
        }


        /// <summary>
        /// The rate each night for the hotel room
        /// </summary>
        public decimal NightlyRate
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NightlyRate)));
            }
        } = decimal.Zero;


        /// <summary>
        /// The room ID number
        /// </summary>
        public long RoomID
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoomID)));
            }
        } = NextID;


        /// <summary>
        /// The room number at the hotel
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
        /// What type the room is
        /// </summary>
        public RoomType RoomType
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoomType)));
            }
        } = RoomType.Standard;


        /// <summary>
        /// If the room is available
        /// </summary>
        public bool IsAvailable
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsAvailable)));
            }
        } = true;

        /// <summary>
        /// What floor number the room is on at the hotel
        /// </summary>
        public int Floor
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Floor)));
            }
        } = 0;

        /// <summary>
        /// How many guests the room can hold
        /// </summary>
        public int Capacity
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Capacity)));
            }
        } = 1;

        /// <summary>
        /// If the room has a balcony
        /// </summary>
        public bool HasBalcony
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HasBalcony)));
            }
        } = false;

        /// <summary>
        /// If the room is clean
        /// </summary>
        public bool IsClean
        {
            get;
            set
            {
                field= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsClean)));
            }
        } = true;

        /// <summary>
        /// The current status of the room
        /// </summary>
        public RoomStatus Status
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
            }
        } = RoomStatus.Available;


    }
}
