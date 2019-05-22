using System;
using System.Collections.Generic;

namespace Project00Data.Data
{
    public partial class Topping
    {
        public Topping()
        {
            Inventory = new HashSet<Inventory>();
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public int? Count { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
