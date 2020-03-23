using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
    }
}
