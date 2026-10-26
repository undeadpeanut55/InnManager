using InnManager.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InnManager.Services
{
    /// <summary>
    /// Represents a service that can be done at a hotel
    /// </summary>
    public class Service : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The name of the service
        /// </summary>
        public string ServiceName
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ServiceName)));
            }
        } = string.Empty;

        /// <summary>
        /// A description of the service
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
        /// How much the service costs
        /// </summary>
        public decimal Price
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Price)));
            }
        } = decimal.Zero;

        /// <summary>
        /// If the service is available
        /// </summary>
        public bool IsAvailable
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsAvailable)));
            }
        } = true;

        /// <summary>
        /// The category the service falls under
        /// </summary>
        public ServiceCategory Category
        {
            get;
            set
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Category)));
            }
        } = ServiceCategory.Miscellaneous;

    }
}
