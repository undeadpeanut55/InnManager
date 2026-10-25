using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents a payment on an invoice
    /// </summary>
    public class Payment : BillingRecord, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// A number assigned to the payment
        /// </summary>
        public string ReferenceNumber
        {
            get;
            set
            {
                ReferenceNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReferenceNumber)));
            }
        } = string.Empty;

        /// <summary>
        /// What method was used for the payment
        /// </summary>
        public PaymentMethod PaymentMethod
        {
            get;
            set
            {
                PaymentMethod = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PaymentMethod)));
            }
        } = PaymentMethod.Cash;

        /// <summary>
        /// The amount but with its sign
        /// </summary>
        public override decimal SignedAmount => -Amount;

    }
}
