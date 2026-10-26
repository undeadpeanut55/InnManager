using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents a billing record
    /// </summary>
    public abstract class BillingRecord : IBillingRecord, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Amount on the record
        /// </summary>
        public decimal Amount
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Amount)));
            }
        } = decimal.Zero;

        /// <summary>
        /// When the record was placed
        /// </summary>
        public DateTime Date
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Date)));
            }
        } = DateTime.Now;

        /// <summary>
        /// Description of the record
        /// </summary>
        public string Description
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        } = string.Empty;

        /// <summary>
        /// If the record is processed
        /// </summary>
        public bool IsProcessed
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsProcessed)));
            }
        } = false;

        /// <summary>
        /// The amount with a sign depending on the type of record
        /// </summary>
        public abstract decimal SignedAmount { get; }
    }
}
