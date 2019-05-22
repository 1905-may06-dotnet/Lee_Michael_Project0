using System;
using System.Collections.Generic;

namespace Project00Data.Data
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public int OrderId { get; set; }
        public int Size { get; set; }
        public int Crust { get; set; }
        public int? ToppingAmount { get; set; }
        public decimal? Cost { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
