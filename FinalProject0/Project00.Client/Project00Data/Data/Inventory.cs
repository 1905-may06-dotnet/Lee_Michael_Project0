using System;
using System.Collections.Generic;

namespace Project00Data.Data
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int RestaurantId { get; set; }
        public int ToppingId { get; set; }
        public int? ItemStock { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual Topping Topping { get; set; }
    }
}
