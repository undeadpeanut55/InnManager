using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class HousekeepingTaskUnitTests
    {
        [Fact]
        public void HousekeepingTaskDefaultValuesTest()
        {
            HousekeepingTask ht = new HousekeepingTask();

            Assert.Empty(ht.RoomNumber);
            Assert.Empty(ht.Description);
            Assert.Equal(DateTime.Now.Date, ht.ScheduledDate.Date);
            Assert.False(ht.IsCompleted);
            Assert.Equal("Not Completed", ht.Status);
        }
    }
}