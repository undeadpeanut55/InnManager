using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class GuestUnitTests
    {
        [Fact]
        public void GuestDefaultValuesTest()
        {
            Guest g = new Guest();

            Assert.Empty(g.FirstName);
            Assert.Empty(g.LastName);
            Assert.Empty(g.Email);
            Assert.Empty(g.PhoneNumber);
            Assert.False(g.IsCheckedIn);
        }
    }
}
