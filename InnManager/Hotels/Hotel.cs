using InnManager.Billing;
using InnManager.Employees;
using InnManager.Enums;
using InnManager.Guests;
using InnManager.Housekeeping;
using InnManager.Reservations;
using InnManager.Rooms;
using InnManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace InnManager.Hotels
{
    /// <summary>
    /// Represents a Hotel
    /// </summary>
    public class Hotel : INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public event PropertyChangedEventHandler? PropertyChanged;


        /// <summary>
        /// The name of the hotel
        /// </summary>
        public string? Name { get; init; }

        /// <summary>
        /// What type of hotel it is
        /// </summary>
        public HotelType Type { get; init; }

        /// <summary>
        /// A list of the rooms in the hotel
        /// </summary>
        public ObservableCollection<Room> Rooms { get; } = new ObservableCollection<Room>();

        /// <summary>
        /// A list of guests at the hotel
        /// </summary>
        public ObservableCollection<Guest> Guests { get; } = new ObservableCollection<Guest>();

        /// <summary>
        /// a list of reservations at the hotel
        /// </summary>
        public ObservableCollection<Reservation> Reservations { get; } = new ObservableCollection<Reservation>();

        /// <summary>
        /// a list of services the hotel provides
        /// </summary>
        public ObservableCollection<Service> Services { get; } = new ObservableCollection<Service>();

        /// <summary>
        /// A list of invoices made at the hotel
        /// </summary>
        public ObservableCollection<Invoice> Invoices { get; } = new ObservableCollection<Invoice>();

        /// <summary>
        /// A list of payments reeived by the hotel
        /// </summary>
        public ObservableCollection<Payment> Payments { get; } = new ObservableCollection<Payment>();

        /// <summary>
        /// A list of employees working at the hotel
        /// </summary>
        public ObservableCollection<Employee> Employees { get; } = new ObservableCollection<Employee>();

        /// <summary>
        /// A list of housekeeping tasks done at the hotel
        /// </summary>
        public ObservableCollection<HousekeepingTask> HousekeepingTasks { get; } = new ObservableCollection<HousekeepingTask>();

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
