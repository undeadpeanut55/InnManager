using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents a hotel room managed by the InnManager system.
    /// </summary>
    /// <remarks>
    /// The Room class stores identifying information about a hotel room, including its room number, room type, nightly rate and current availability.
    /// </remarks>
    public class Room
    {
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
        public decimal NightlyRate { get; set; } = decimal.Zero;

        /// <summary>
        /// The room ID number
        /// </summary>
        public long RoomID { get; set; } = NextID;

        /// <summary>
        /// The room number at the hotel
        /// </summary>
        public string RoomNumber { get; set; } = string.Empty;

        /// <summary>
        /// What type the room is
        /// </summary>
        public RoomType RoomType { get; set; } = RoomType.Standard;

        /// <summary>
        /// If the room is available
        /// </summary>
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// What floor number the room is on at the hotel
        /// </summary>
        public int Floor { get; set; } = 0;

        /// <summary>
        /// How many guests the room can hold
        /// </summary>
        public int Capacity { get; set; } = 1;

        /// <summary>
        /// If the room has a balcony
        /// </summary>
        public bool HasBalcony { get; set; } = false;

        /// <summary>
        /// If the room is clean
        /// </summary>
        public bool IsClean { get; set; } = true;

        /// <summary>
        /// The current status of the room
        /// </summary>
        public RoomStatus Status { get; set; } = RoomStatus.Available;


    }
}
