using System;
using System.Collections.Generic;
using System.Text;
using Project00Data;
using Project00Data.Data;

namespace Project00.Domain
{
    public class Pizza
    {
        public Sizes Size { get; set; }
        public Crusts Crust { get; set; }
        public decimal Cost { get; set; }
        public List<Toppings> Topping = new List<Toppings>();

        public enum Sizes
        {
            Small,
            Large,
            ExtraLarge
        }
        public enum Crusts
        {
            Garlic,
            ThinCrispy,
            ChesseStuffed
        }
        public enum Toppings
        {
            Pepperoni,
            Sausage,
            Ham,
            Chicken,
            Mushrooms,
            Onions,
            Olives,
            GreenPepper,
            BananaPepper,
            Jalapenos,
            Tomatoes

        };

        public class PizzaLogic
        {
            public decimal CreatePizza(Pizza p, List<Toppings> toppings)
            {
                Sizes pSize = (Sizes)p.Size;
                Crusts pCrust = (Crusts)p.Crust;

                decimal cost;
                cost = 0;

                switch (pSize)
                {
                    case Sizes.Small:
                        cost = 6.5m;
                        break;

                    case Sizes.Large:
                        cost = 10m;
                        break;

                    case Sizes.ExtraLarge:
                        cost = 12.5m;
                        break;

                    default:
                        cost = 8m;
                        break;
                }

                switch (pCrust)
                {
                    case Crusts.Garlic:
                        cost += .5m;
                        break;
                    case Crusts.ChesseStuffed:
                        cost += 1.5m;
                        break;
                    case Crusts.ThinCrispy:
                        cost += 0m;
                        break;
                    default:
                        cost += 0m;
                        break;
                }

                if (toppings.Count <= 5)
                {
                    Console.WriteLine("You cannot have more than 5 toppings on your pizza at this time, try again this will only add the first 5 toppings.");

                }
                else
                {
                    cost += (toppings.Count * .5m);
                }

                return cost;
            }

        }
    }
}
