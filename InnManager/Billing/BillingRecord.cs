using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents a billing record
    /// </summary>
    public abstract class BillingRecord : IBillingRecord
    {
        /// <summary>
        /// Amounton the record
        /// </summary>
        public decimal Amount { get; set; } = decimal.Zero;

        /// <summary>
        /// When the record was placed
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Description of the record
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// If the record is processed
        /// </summary>
        public bool IsProcessed { get; set; } = false;

        /// <summary>
        /// The amount with a sign depending on the type of record
        /// </summary>
        public abstract decimal SignedAmount { get; }
    }
}
