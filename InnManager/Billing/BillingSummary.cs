using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents a way to summarize billing records
    /// </summary>
    public class BillingSummary
    {
        /// <summary>
        /// The collection of billing records
        /// </summary>
        private readonly IEnumerable<IBillingRecord> _records;

        /// <summary>
        /// The constructor for the summary
        /// </summary>
        /// <param name="records"></param>
        public BillingSummary(IEnumerable<IBillingRecord> records) { _records = records; }

        /// <summary>
        /// The total charges on record
        /// </summary>
        public decimal TotalCharges
        {
            get
            {
                decimal total = 0;
                foreach(BillingRecord record in _records)
                {
                    if(record.IsProcessed && record is Charge)
                    {
                        total += record.Amount;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// The total payments on record
        /// </summary>
        public decimal TotalPayments
        {
            get
            {
                decimal total = 0;
                foreach (BillingRecord record in _records)
                {
                    if (record.IsProcessed && record is Payment)
                    {
                        total += record.Amount;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// The balance after payments and charges are applied on record
        /// </summary>
        public decimal NetBalance
        {
            get
            {
                decimal total = 0;
                foreach (BillingRecord record in _records)
                {
                    if (record.IsProcessed)
                    {
                        total += record.SignedAmount;
                    }
                }
                return total;
            }
        }


    }
}
