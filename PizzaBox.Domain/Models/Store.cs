using System;
using System.Collections.Generic;

namespace PizzaBox.domain
{

    public class Store{
        public List<Order> orders {get; set;}
        public string Name {get; set;}
        public Order CreateOrder(){
            return new Order();
        }
    }
    
}