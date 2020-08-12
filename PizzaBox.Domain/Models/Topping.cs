using System;

namespace PizzaBox.Domain
{
    public class Topping
    {
        public string Name {get; set;}

        public Topping(string name){
            Name = name;
        }

        public bool isEqual(Topping t) {
            if(t == null) {
                return false;
            } else {
                return (Name == t.Name);
            }
        }

    }
}