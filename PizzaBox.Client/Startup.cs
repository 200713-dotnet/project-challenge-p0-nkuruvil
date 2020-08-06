using System;
using System.Collections.Generic;
using PizzaBox.domain;

namespace PizzaBox.Client{
    public class Startup{
        public Pizza createPizza(Crust crust, Size size, List<Topping> toppings) {
            Pizza p = new Pizza();
            p.Crust = crust;
            p.Size = size;
            p.Toppings.AddRange(toppings);
            return p;
        }
    }
}