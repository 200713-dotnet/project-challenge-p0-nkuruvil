using System;
using System.Collections.Generic;

namespace PizzaBox.domain
{
    public class User
    {
        public string name {get; set;}
        public List<Order> Orders {get; set;}

    }
}