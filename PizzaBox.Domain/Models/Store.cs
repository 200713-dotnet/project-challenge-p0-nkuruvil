using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{

    public class Store{
        public List<Order> Orders {get; set;}
        public string Name {get; set;}

        public Store()
        {
            Orders = new List<Order>();
        }

        public void addOrder(Order order)
        {
            Orders.Add(order);
        }

        public void listAllOrders()
        {
            var sb = new StringBuilder();
            int count = 0;
            foreach(Order o in Orders){
                sb.Append(count + ":{" + o + "};");
            }
            string orderstring = $"{sb}";
            Console.Write(orderstring);
        }
    }
    
}