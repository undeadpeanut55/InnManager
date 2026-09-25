using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class ServiceUnitTests
    {
        [Fact]
        public void ServiceDefaultValuesTest()
        {
            Service s = new Service();

            Assert.Empty(s.ServiceName);
            Assert.Empty(s.Description);
            Assert.Equal(decimal.Zero, s.Price);
            Assert.True(s.IsAvailable);
            Assert.Equal(ServiceCategory.Miscellaneous, s.Category);
        }
    }
}
