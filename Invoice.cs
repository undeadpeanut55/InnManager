using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    public class Invoice
    {

        public string GuestName { get; set; } = string.Empty;

        public string RoomNumber { get; set; } = string.Empty;

        public decimal RoomCharge { get; set; } = decimal.Zero;

        public decimal ServiceCharge { get; set; } = decimal.Zero;

        public bool IsPaid { get; set; } = false;

        public decimal TotalAmount
        {
            get
            {
                return RoomCharge + ServiceCharge;
            }
        }

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
