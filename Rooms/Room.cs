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
        private static long _nextID = 0;

        public static long NextID
        {
            get
            {
                _nextID++;
                return _nextID;
            }
        }

        public decimal NightlyRate { get; set; } = decimal.Zero;

        public long RoomID { get; set; } = NextID;

        public string RoomNumber { get; set; } = string.Empty;

        public string RoomType { get; set; } = string.Empty;

        public bool IsAvailable { get; set; } = true;

        public int Floor { get; set; } = 0;

        public int Capacity { get; set; } = 1;

        public bool HasBalcony { get; set; } = false;

        public bool IsClean { get; set; } = true;

        public string Status { get; set; } = "Available";


    }
}
