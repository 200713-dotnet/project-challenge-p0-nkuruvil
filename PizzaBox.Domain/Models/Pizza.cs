using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{
    public class Pizza{
        public Crust crust {get; set;}
        public Size size {get; set;}
        public Topping[] toppings {get; set;}


        public Pizza(){
            toppings = new Topping[5];
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