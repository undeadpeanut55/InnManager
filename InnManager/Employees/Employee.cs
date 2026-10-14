using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager.Employees
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
        /// The employee's email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The employee's phone number
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// The date the Employee was hired
        /// </summary>
        public DateTime HireDate { get; set; } = DateTime.Now;

        /// <summary>
        /// If the employee is active
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// The active status of the employee
        /// </summary>
        public string Status
        {
            get
            {
                if (IsActive) return "Active";
                return "Inactive";
            }
        }

    }
}
