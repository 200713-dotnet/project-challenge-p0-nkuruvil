using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{
    public class User
    {
        public string name {get; set;}
        public List<Order> Orders {get; set;}

        public User()
        {
            Orders = new List<Order>();
        }

        public void addOrder(Order order)
        {
            Orders.Add(order);
        }

        public string listOrders()
        {
            var sb = new StringBuilder();
            int count = 0;
            foreach(Order o in Orders){
                sb.Append(count + $"{o.Pizzas.Count} Pizzas");
            }
            return $"{sb}";
        }

    }
}