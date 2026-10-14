using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents an invoice for a guest
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// An auto generated number used to uniquely identify an invoice
        /// </summary>
        public string InvoiceNumber { get; set; } = string.Empty;

        /// <summary>
        /// The time the invoice was created
        /// </summary>
        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Name of the guest responsible for the invoice
        /// </summary>
        public string GuestName { get; set; } = string.Empty;

        /// <summary>
        /// Room number that is responsible for the invoice
        /// </summary>
        public string RoomNumber { get; set; } = string.Empty;

        /// <summary>
        /// When the invoice is due
        /// </summary>
        public DateTime DueDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Aa list of billing records on the invoice
        /// </summary>
        public List<BillingRecord> BillingRecords { get; } = new List<BillingRecord>();
        
        /// <summary>
        /// Total charges on the invoice
        /// </summary>
        public decimal TotalCharges
        {
            get
            {
                decimal total = 0;
                foreach(BillingRecord record in BillingRecords)
                {
                    if(record is Charge && record.IsProcessed)
                    {
                        total += record.Amount;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// Total payments on the invoice
        /// </summary>
        public decimal TotalPayments
        {
            get
            {
                decimal total = 0;
                foreach(BillingRecord record in BillingRecords)
                {
                    if(record is Payment && record.IsProcessed)
                    {
                        total += record.Amount;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// Balance due on the invoice
        /// </summary>
        public decimal BalanceDue
        {
            get
            {
                decimal balance = 0;
                foreach (BillingRecord record in BillingRecords)
                {
                    if (record.IsProcessed)
                    {
                        balance += record.SignedAmount;
                    }
                }
                return balance;
            }
        }


        /// <summary>
        /// Status of the invoice
        /// </summary>
        public string Status
        {
            get
            {
                if (BalanceDue <= 0) return "Paid";
                return "Unpaid";
            }
        }


    }
}
