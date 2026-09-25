using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class ReservationUnitTests
    {
        [Fact]
        public void ReservationDefaultValuesTest()
        {
            Reservation r = new Reservation();

            Assert.Empty(r.GuestName);
            Assert.Empty(r.RoomNumber);
            Assert.Equal(DateTime.Now.Date, r.CheckInDate.Date);
            Assert.Equal(DateTime.Now.Date, r.CheckOutDate.Date);
            Assert.False(r.IsCheckedOut);
            Assert.False(r.IsConfirmed);
            Assert.False(r.IsCheckedOutOverdue);
            Assert.False(r.IsActive);
            Assert.Equal("Pending", r.Status);
        }

        [Theory]
        [InlineData(1,false, false, false, false,"Pending")]
        [InlineData(1, false,true, false, true,"Confirmed")]
        [InlineData(-1, false, false,true, false, "Overdue")]//
        [InlineData(-1, false, true, true, true, "Overdue")]//
        [InlineData(0, false, false, false, false, "Pending")]
        [InlineData(0, false, true, false, true, "Confirmed")]
        [InlineData(-1, true, true, false, false,"Checked Out")]//
        [InlineData(1, true, true, false, false, "Checked Out")]
        public void OverdueIsActiveAndStatusCorrect(int checkoutOffset,bool actualIsCheckedOut, bool actualIsConfirmed, bool expectedIsCheckedOutOverdue, bool expectedIsActive, string expectedStatus)
        {
            Reservation r = new Reservation();

            r.CheckOutDate = DateTime.Now.AddDays(checkoutOffset);
            r.IsCheckedOut = actualIsCheckedOut;
            r.IsConfirmed = actualIsConfirmed;

            Assert.Equal(expectedIsCheckedOutOverdue, r.IsCheckedOutOverdue);
            Assert.Equal(expectedIsActive, r.IsActive);
            Assert.Equal(expectedStatus, r.Status);

        }


    }
}
