using System;
using System.Collections.Generic;

namespace Project0.Data.Entities
{
    public partial class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Stret { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? UserId { get; set; }
    }
}
