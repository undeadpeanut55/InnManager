using System;
using System.Collections.Generic;
using System.Text;

namespace InnManager
{
    public class Service
    {

        public string ServiceName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; } = decimal.Zero;

        public bool IsAvailable { get; set; } = true;

    }
}
