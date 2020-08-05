using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{
    public class Pizza{
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public List<Topping> Toppings {get; set;}


        public Pizza(){
            Toppings = new List<Topping>();
        }

        public Pizza(Crust crust, Size size, Topping[] toppings)
        {
            Crust = crust;
            Size = size;
            Toppings.AddRange(toppings);
        }

        public override string ToString(){
            var sb = new StringBuilder();
            //string toppingsList = "{";
            foreach(Topping t in Toppings){
                sb.Append(t.Name + ",");
            }
            //toppingsList = toppingsList.Substring(0, toppingsList.Length-2);
            //toppingsList += "}";
            string pizzaString = $"Size={Size.Name}; Crust={Crust.Name}; Toppings={sb}";
            return pizzaString;

        }
    }
}