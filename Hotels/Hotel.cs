using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents a Hotel
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// The name of the hotel
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// What type of hotel it is
        /// </summary>
        public HotelType Type { get; init; }

        /// <summary>
        /// A list of the rooms in the hotel
        /// </summary>
        public List<Room> Rooms { get; } = new List<Room>();

        /// <summary>
        /// A list of guests at the hotel
        /// </summary>
        public List<Guest> Guests { get; } = new List<Guest>();

        /// <summary>
        /// a list of reservations at the hotel
        /// </summary>
        public List<Reservation> Reservations { get; } = new List<Reservation>();

        /// <summary>
        /// a list of services the hotel provides
        /// </summary>
        public List<Service> Services { get; } = new List<Service>();

        /// <summary>
        /// A list of invoices made at the hotel
        /// </summary>
        public List<Invoice> Invoices { get; } = new List<Invoice>();

        /// <summary>
        /// A list of payments reeived by the hotel
        /// </summary>
        public List<Payment> Payments { get; } = new List<Payment>();

        /// <summary>
        /// A list of employees working at the hotel
        /// </summary>
        public List<Employee> Employees { get; } = new List<Employee>();

        /// <summary>
        /// A list of housekeeping tasks done at the hotel
        /// </summary>
        public List<HousekeepingTask> HousekeepingTasks { get; } = new List<HousekeepingTask>();

        /// <summary>
        /// The number of available rooms at the hotel
        /// </summary>
        public int AvailableRoomCount
        {
            get
            {
                int roomCount = 0;
                foreach(Room room in Rooms)
                {
                    if(room.Status == RoomStatus.Available)
                    {
                        roomCount++;
                    }
                }
                return roomCount;
            }
        }

        /// <summary>
        /// The number of occupied rooms at the hotel
        /// </summary>
        public int OccupiedRoomCount
        {
            get
            {
                int roomCount = 0;
                foreach(Room room in Rooms)
                {
                    if(room.Status == RoomStatus.Occupied)
                    {
                        roomCount++;
                    }
                }
                return roomCount;
            }
        }

    }
}
