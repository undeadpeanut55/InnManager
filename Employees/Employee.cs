using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents an employee at a hotel
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The employee's ID number as a string
        /// </summary>
        public string EmployeeID { get; set; } = string.Empty;

        /// <summary>
        /// The employee's first name
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// The employee's last name
        /// </summary>
        public string LastName {  get; set; } = string.Empty;

        /// <summary>
        /// The employee's position at the hotel
        /// </summary>
        public EmployeePosition Position { get; set; } = EmployeePosition.FrontDesk;

        /// <summary>
        /// If the employee is active
        /// </summary>
        public bool IsActive { get; set; } = true;

    }
}
