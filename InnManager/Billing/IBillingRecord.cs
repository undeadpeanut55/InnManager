using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager.Billing
{
    /// <summary>
    /// Interface that represents the minimal information requirede by summary and reporting classes
    /// </summary>
    public interface IBillingRecord
    {
        /// <summary>
        /// Amount for the record
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// Date the record was made
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// If the record was processed
        /// </summary>
        public bool IsProcessed { get; }

        /// <summary>
        /// The amount with a + or - depending on the record
        /// </summary>
        public decimal SignedAmount { get; }




    }
}
