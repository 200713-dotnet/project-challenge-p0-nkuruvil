using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{
    public class Pizza{
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public Topping[] Toppings {get; set;}


        public Pizza(){
            Toppings = new Topping[5];
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
            foreach(Topping t in toppings){
                sb.Append(t.name + ", ");
            }
            //toppingsList = toppingsList.Substring(0, toppingsList.Length-2);
            //toppingsList += "}";
            string pizzaString = $"Size={size}; Crust={crust}; Toppings={sb}";
            return pizzaString;

        }
    }
}