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

        public decimal NightlyRate { get; set; } = 0m;

        public static long NextID
        {
            get
            {
                _nextID++;
                return _nextID;
            }
        }

        public long RoomID { get; set; } = NextID;

        public string RoomNumber { get; set; } = "";

        public string RoomType { get; set; } = "";

        public bool IsAvailable { get; set; } = true;


    }
}
