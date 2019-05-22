using System;
using System.Collections.Generic;

namespace Project00Data.Data
{
    public partial class Orders
    {
        public Orders()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int OrderId { get; set; }
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
