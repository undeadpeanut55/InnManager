using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents an invoice for a guest
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Name of the guest responsible for the invoice
        /// </summary>
        public string GuestName { get; set; } = string.Empty;

        /// <summary>
        /// Room number that is responsible for the invoice
        /// </summary>
        public string RoomNumber { get; set; } = string.Empty;

        /// <summary>
        /// Charge on the invoice for the room
        /// </summary>
        public decimal RoomCharge { get; set; } = decimal.Zero;

        /// <summary>
        /// Charge on the invoice for services
        /// </summary>
        public decimal ServiceCharge { get; set; } = decimal.Zero;

        /// <summary>
        /// If the invoice is paid
        /// </summary>
        public bool IsPaid { get; set; } = false;

        /// <summary>
        /// Total amount on the invoice
        /// </summary>
        public decimal TotalAmount
        {
            get
            {
                return RoomCharge + ServiceCharge;
            }
        }

        /// <summary>
        /// Status of the invoice
        /// </summary>
        public string Status
        {
            get
            {
                if (IsPaid) return "Paid";
                return "Unpaid";
            }
        }


    }
}
