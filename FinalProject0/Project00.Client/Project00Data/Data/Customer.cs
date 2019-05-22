using System;
using System.Collections.Generic;

namespace Project00Data.Data
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
