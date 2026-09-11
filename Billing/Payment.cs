using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    public class Payment
    {

        public decimal Amount { get; set; } = decimal.Zero;

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public string PaymentMethod { get; set; } = string.Empty;

        public bool IsSuccessful { get; set; } = false;


    }
}
