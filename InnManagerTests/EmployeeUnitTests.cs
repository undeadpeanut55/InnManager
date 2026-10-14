using InnManager.Employees;
using InnManager.Enums;
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
            Assert.Empty(e.Email);
            Assert.Empty(e.PhoneNumber);
            Assert.Equal(DateTime.Now.Date, e.HireDate.Date);
        }

        [Fact]
        public void EmployeeStatusWorksAsIntended()
        {
            Employee e = new Employee();

            e.IsActive = false;
            Assert.Equal("Inactive",e.Status);

            e.IsActive = true;
            Assert.Equal("Active", e.Status);

            e.IsActive = false;
            Assert.Equal("Inactive", e.Status);
        }
    }
}
