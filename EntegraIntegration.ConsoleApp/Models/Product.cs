using System;
using System.Collections.Generic;
using System.Text;

namespace EntegraIntegration.ConsoleApp.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public long Quantity { get; set; }
    }
}
