using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    public class Employee
    {

        public string EmployeeID { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName {  get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

    }
}
