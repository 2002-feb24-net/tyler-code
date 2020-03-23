using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class CustomerOrder
    {
        public int OrderId { get; set; }
        public string Product { get; set; }
        public decimal? Price { get; set; }
        public int? Quanity { get; set; }
        public string CustomerName { get; set; }
    }
}
