using System;

namespace PizzaBox.Domain
{
    public class Topping
    {
        public string Name {get; set;}

        public Topping(string name){
            Name = name;
        }

    }
}