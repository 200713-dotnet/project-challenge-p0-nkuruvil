using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.domain
{
    public class Order{
        public List<Pizza> Pizzas {get; set;}
        public DateTime DateOrdered {get; set;}

        public void createPizza(){
            Pizzas.Add(new Pizza());
        }

        public void addPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int count = 0;
            foreach(Pizza p in Pizzas){
                sb.Append(count + ":{" + p + "};");
            }
            string orderstring = $"{sb}";
            return orderstring;
        }
    }
}