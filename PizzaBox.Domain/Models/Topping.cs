using System;

namespace PizzaBox.domain
{
    public class Topping
    {
        public string name {get; set;}

        public Topping(String n){
            name = n;
        }
    }
}