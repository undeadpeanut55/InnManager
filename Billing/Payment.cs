using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents a payment on an invoice
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// The amount on the payment
        /// </summary>
        public decimal Amount { get; set; } = decimal.Zero;

        /// <summary>
        /// When the payment was made
        /// </summary>
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        /// <summary>
        /// What method was used for the payment
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;

        /// <summary>
        /// If the payment was successful
        /// </summary>
        public bool IsSuccessful { get; set; } = false;


    }
}
