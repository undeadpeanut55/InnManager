using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class HotelUnitTests
    {
        [Fact]
        public void HotelDefaultValuesTest()
        {
            Hotel h = new Hotel {Name = "Old Hotel", Type = HotelType.ExtendedStay };

            Assert.Empty(h.Rooms);
            Assert.Empty(h.Guests);
            Assert.Empty(h.Reservations);
            Assert.Empty(h.Services);
            Assert.Empty(h.Invoices);
            Assert.Empty(h.Payments);
            Assert.Empty(h.Employees);
            Assert.Empty(h.HousekeepingTasks);

            Assert.Equal(0, h.AvailableRoomCount);
            Assert.Equal(0, h.OccupiedRoomCount);

        }

        [Theory]
        [InlineData(RoomStatus.Available, RoomStatus.Available, RoomStatus.Available, RoomStatus.Available, RoomStatus.Available,5,0)]
        [InlineData(RoomStatus.Occupied, RoomStatus.Occupied, RoomStatus.Occupied, RoomStatus.Occupied, RoomStatus.Occupied,0,5)]
        [InlineData(RoomStatus.Available, RoomStatus.Occupied, RoomStatus.Available, RoomStatus.Occupied, RoomStatus.Available,3,2)]
        [InlineData(RoomStatus.Reserved, RoomStatus.Maintenance, RoomStatus.Reserved, RoomStatus.Maintenance, RoomStatus.Reserved,0,0)]
        [InlineData(RoomStatus.Available, RoomStatus.Reserved, RoomStatus.Occupied, RoomStatus.Maintenance, RoomStatus.Available,2,1)]
        [InlineData(RoomStatus.Occupied, RoomStatus.Reserved, RoomStatus.Occupied, RoomStatus.Maintenance, RoomStatus.Available,1,2)]
        [InlineData(RoomStatus.Maintenance, RoomStatus.Available, RoomStatus.Maintenance, RoomStatus.Available, RoomStatus.Occupied,2,1)]
        [InlineData(RoomStatus.Reserved, RoomStatus.Occupied, RoomStatus.Available, RoomStatus.Occupied, RoomStatus.Reserved,1,2)]
        public void BothRoomCountsAreCorrect(RoomStatus r1Status, RoomStatus r2Status, RoomStatus r3Status, RoomStatus r4Status, RoomStatus r5Status, int expectedAvailable, int expectedOccupied)
        {
            Hotel h = new Hotel { Name = "Test Hotel", Type = HotelType.Airport };

            Room r1 = new Room { Status = r1Status };
            Room r2 = new Room { Status = r2Status };
            Room r3 = new Room { Status = r3Status };
            Room r4 = new Room { Status = r4Status };
            Room r5 = new Room { Status = r5Status };

            h.Rooms.Add(r1);
            h.Rooms.Add(r2);
            h.Rooms.Add(r3);
            h.Rooms.Add(r4);
            h.Rooms.Add(r5);

            Assert.Equal(expectedOccupied, h.OccupiedRoomCount);
            Assert.Equal(expectedAvailable, h.AvailableRoomCount);

        }

    }
}
