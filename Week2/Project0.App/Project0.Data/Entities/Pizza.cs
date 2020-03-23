using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string TypeOfPizza { get; set; }
        public decimal? Price { get; set; }
    }
}
