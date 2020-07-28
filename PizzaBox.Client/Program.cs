using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.client
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr = new PizzaRepository();
            var pizza = new Pizza()
            {
                Crust = new Crust() {Name = "NY Style"},
                Size = new Size() {Name = "Medium"},
                Toppings = new List<Topping>(){new Topping(){Name = "Cheese"}}
            };

            pr.Create(pizza);
            Console.ReadLine();

            foreach(var item in pr.ReadAll())
            {
                System.Console.WriteLine(item);
            }

            Console.WriteLine("Hello User!");
            Console.WriteLine("Select 1 for user or 2 for store");



        }

        static void UserExperience()
        {

        }

        static void StoreExperience()
        {

        }

        static void Menu()
        {
            
        }
    }
}
