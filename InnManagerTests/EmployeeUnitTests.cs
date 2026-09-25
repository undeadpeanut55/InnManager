using InnManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManagerTests
{
    public class EmployeeUnitTests
    {
        [Fact]
        public void EmployeeDefaultValuesTest()
        {
            Employee e = new Employee();

            Assert.Empty(e.EmployeeID);
            Assert.Empty(e.FirstName);
            Assert.Empty(e.LastName);
            Assert.Equal(EmployeePosition.FrontDesk, e.Position);
            Assert.True(e.IsActive);
        }
    }
}
