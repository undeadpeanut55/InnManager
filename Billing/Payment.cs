using InnManager.Billing;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents a payment on an invoice
    /// </summary>
    public class Payment : BillingRecord
    {

        /// <summary>
        /// What method was used for the payment
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;

        /// <summary>
        /// The amount but with its sign
        /// </summary>
        public override decimal SignedAmount => -Amount;

    }
}
