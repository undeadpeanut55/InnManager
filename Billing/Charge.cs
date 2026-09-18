using System;
using System.Collections.Generic;
using System.Text;
using InnManager.Enums;

namespace InnManager.Billing
{
    /// <summary>
    /// A billing record that is a charge added to an invoice
    /// </summary>
    public class Charge : BillingRecord
    {
        /// <summary>
        /// The category of the charge
        /// </summary>
        public ChargeCategory Category { get; set; }

        /// <summary>
        /// The signed version of the amount charged
        /// </summary>
        public override decimal SignedAmount => Amount;
    }
}
