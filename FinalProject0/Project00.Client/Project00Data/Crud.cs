using System;
using System.Linq;
using Project00Data.Data;
using System.Collections.Generic;


namespace Project00Data
{
    public class Crud
    {
        public void AddUser(Customer u)
        {
            DbInstance.Instance.Customer.Add(u);
            DbInstance.Instance.SaveChanges();
        }

        public void UpdateUser(Customer u)
        {
            DbInstance.Instance.Customer.Update(u);
            DbInstance.Instance.SaveChanges();
        }

        public void RemoveUser(Customer u)
        {
            DbInstance.Instance.Customer.Remove(u);
            DbInstance.Instance.SaveChanges();
        }

        public Customer GetUser(string Username)
        {
            return DbInstance.Instance.Customer.Where(u => u.Username == Username).FirstOrDefault();
        }
        public bool UserValidation(string Username, string Password)
        {
            return (DbInstance.Instance.Customer.Where<Customer>(u => u.Username == Username).FirstOrDefault().Password == Password);
        }

        public bool UniqueUsername(string Username)
        {
            var userExists = DbInstance.Instance.Customer.Where<Customer>(u => u.Username == Username).FirstOrDefault();
            if (userExists != null)
                return true;
            else
                return false;
        }

        public void AddOrders(Orders o)
        {
            DbInstance.Instance.Orders.Add(o);
            DbInstance.Instance.SaveChanges();
        }

        public void RemoveOrder(Orders o)
        {
            Pizza[] pizzas = DbInstance.Instance.Pizza.Where(p => p.OrderId == o.OrderId).ToArray();
            DbInstance.Instance.Pizza.RemoveRange(pizzas);
            DbInstance.Instance.Orders.Remove(o);
            DbInstance.Instance.SaveChanges();
        }
        public Orders GetMostRecentOrder(Customer u)
        {
            return DbInstance.Instance.Orders.Where<Orders>(o => o.CustomerId == u.CustomerId).OrderByDescending(o => o.OrderDate).FirstOrDefault();
        }

        public List<Orders> GetUserOrderList(Customer u)
        {
            return DbInstance.Instance.Orders.Where<Orders>(o => o.CustomerId == u.CustomerId).ToList();
        }
        public HashSet<Pizza> GetOrderPizzas(Orders o)
        {
            return DbInstance.Instance.Pizza.Where<Pizza>(p => p.OrderId == o.OrderId).ToHashSet();
        }

        public HashSet<PizzaTopping> GetPizzaToppings(Pizza p)
        {
            return DbInstance.Instance.PizzaTopping.Where<PizzaTopping>(pt => pt.PizzaId == p.PizzaId).ToHashSet();
        }

        public List<Restaurant> GetRestaurantList()
        {
            return DbInstance.Instance.Restaurant.ToList();
        }

        public Restaurant GetRestaurantList(int ID)
        {
            return DbInstance.Instance.Restaurant.Where<Restaurant>(t => t.RestaurantId == ID).FirstOrDefault();
        }

        public List<Topping> GetToppingList()
        {
            return DbInstance.Instance.Topping.ToList();
        }

        public Topping GetToppingList(int ID)
        {
            return DbInstance.Instance.Topping.Where<Topping>(t => t.ToppingId == ID).FirstOrDefault();
        }

    }

}
