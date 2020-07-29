using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{
    public class Order{
        public List<Pizza> Pizzas {get; set;}
        public DateTime DateOrdered {get; set;}

        public Store Store {get; set;}
        public User User {get; set;}

        public Order(Store store, User user){
            Store = store;
            User = user;
            Pizzas = new List<Pizza>();
        }

        public void createPizza(){
            Pizzas.Add(new Pizza());
        }

        public void addPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public string ShowCart()
        {
            var sb = new StringBuilder();
            int count = 0;
            foreach(Pizza p in Pizzas){
                sb.Append(count + ":{" + p + "};");
            }
            string orderstring = $"{sb}";
            return orderstring;
        }
    }
}