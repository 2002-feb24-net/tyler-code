﻿using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public decimal? Price { get; set; }
    }
}
