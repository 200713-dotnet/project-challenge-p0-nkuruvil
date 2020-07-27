using System;
using System.Collections.Generic;

namespace PizzaBox.domain
{
    public class Order{
        public List<Pizza> Pizzas {get; set;}
        public DateTime DateOrdered {get; set;}

        public void createPizza(){
            Pizzas.Add(new Pizza());
        }
    }
}