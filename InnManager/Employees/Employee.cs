using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Employees
{
    /// <summary>
    /// Represents an employee at a hotel
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;


        /// <summary>
        /// The employee's ID number as a string
        /// </summary>
        public string EmployeeID
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmployeeID)));
            }
        } = string.Empty;

        /// <summary>
        /// The employee's first name
        /// </summary>
        public string FirstName 
        { 
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            } 
        } = string.Empty;

        /// <summary>
        /// The employee's last name
        /// </summary>
        public string LastName
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        } = string.Empty;

        /// <summary>
        /// The employee's position at the hotel
        /// </summary>
        public EmployeePosition Position
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
            }
        } = EmployeePosition.FrontDesk;

        /// <summary>
        /// The employee's email
        /// </summary>
        public string Email
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        } = string.Empty;

        /// <summary>
        /// The employee's phone number
        /// </summary>
        public string PhoneNumber
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PhoneNumber)));
            }
        } = string.Empty;

        /// <summary>
        /// The date the Employee was hired
        /// </summary>
        public DateTime HireDate
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HireDate)));
            }
        } = DateTime.Now;

        /// <summary>
        /// If the employee is active
        /// </summary>
        public bool IsActive
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsActive)));
            }
        } = true;

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
