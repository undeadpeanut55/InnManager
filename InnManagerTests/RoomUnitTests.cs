using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class RoomUnitTests
    {
        [Fact]
        public void RoomDefaultValuesTest()
        {
            Room r = new Room();

            Assert.Equal(0, r.Floor);
            Assert.Equal(1, r.Capacity);
            Assert.False(r.HasBalcony);
            Assert.True(r.IsClean);
            Assert.Equal(RoomType.Standard, r.RoomType);
            Assert.Equal(RoomStatus.Available, r.Status);
        }
    }
}
