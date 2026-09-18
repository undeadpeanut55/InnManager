using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents a guest staying at a hotel
    /// </summary>
    public class Guest
    {
        /// <summary>
        /// The guest's first name
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// The guest's last name
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// The guest's email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// The guest's phone number as a string
        /// </summary>
        public string PhoneNumber {  get; set; } = string.Empty;

        /// <summary>
        /// If the guest has checked in
        /// </summary>
        public bool IsCheckedIn { get; set; } = false;

    }
}
