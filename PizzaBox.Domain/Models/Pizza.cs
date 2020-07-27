using System;
using System.Collections.Generic;
namespace PizzaBox.domain
{
    public class Pizza{
        public Crust crust {get; set;}
        public Size size {get; set;}
        public Topping[] toppings {get; set;}


        public Pizza(){
            
        }

    }
}