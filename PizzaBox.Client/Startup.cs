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

        public void AddToppings(List<Topping> toppings, Topping topping) {
            foreach(Topping t in toppings) {
                if (t.isEqual(topping)) {
                    return;
                }
            }
            toppings.Add(topping);
        }

        public Store SelectStore(Store store1, Store store2) {
            System.Console.WriteLine("Pick store 1 or 2 to view");
            int choice = 0;
            int.TryParse(Console.ReadLine(), out choice);
            if(choice == 2){
                return store2;
            }else{
                return store1;
            }
        }

    }
}