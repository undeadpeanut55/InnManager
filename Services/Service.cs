using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    /// <summary>
    /// Represents a service that can be done at a hotel
    /// </summary>
    public class Service
    {
        /// <summary>
        /// The name of the service
        /// </summary>
        public string ServiceName { get; set; } = string.Empty;

        /// <summary>
        /// A description of the service
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// How much the service costs
        /// </summary>
        public decimal Price { get; set; } = decimal.Zero;
        /// <summary>
        /// If the service is available
        /// </summary>
        public bool IsAvailable { get; set; } = true;
        /// <summary>
        /// The category the service falls under
        /// </summary>
        public ServiceCategory Category { get; set; } = ServiceCategory.Miscellaneous;

    }
}
