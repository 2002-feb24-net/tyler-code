using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo3
{
    class OrderDetial
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}
