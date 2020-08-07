using System;
using System.Collections.Generic;
using PizzaBox.Domain;

namespace PizzaBox.Client{
    public class Startup{


        public Order startOrder(User user, Store store) {
            Order o = new Order(store, user);
            user.addOrder(o);
            store.addOrder(o);
            return o;

        }
        public Pizza createPizza(Crust crust, Size size, List<Topping> toppings) {
            Pizza p = new Pizza();
            p.Crust = crust;
            p.Size = size;
            p.Toppings.AddRange(toppings);
            return p;
        }
    }
}