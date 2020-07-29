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

            
            int select = 0;
            var user = new User();
            var store = new Store();
            do{
                Console.WriteLine("Hello User!");
                Console.WriteLine("Select 1 for user or 2 for store");
                int.TryParse(Console.ReadLine(), out select);
                if(select == 1){
                    Order order = new Order(store, user);
                    Menu(order);

                }else if(select == 2){

                }else{
                    Console.WriteLine("Invalid Number, please try again");
                    select = 0;
                }


            }while(select != 0);


        }

        static void UserExperience()
        {

        }

        static void StoreExperience()
        {

        }

        static void Menu(Order order)
        {
            if (cart is null)
            {
                throw new ArgumentNullException(nameof(cart));
            }

            int numPizzas = 0;
            bool exit = false;
            var startup = new PizzaStore.Client.Startup();

            // Plan:
            // Ask for size
            // Ask for crust
            // Ask for toppings on at a time.

            do
            {

                // if
                        System.Console.WriteLine("Select Toppings");
                        System.Console.WriteLine("Select 1 for Cheese Pizza");
                        System.Console.WriteLine("Select 2 for Pepperoni Pizza");
                        System.Console.WriteLine("Select 3 for Sausage Pizza");
                        System.Console.WriteLine("Select 4 for Vegetarian Pizza");
                        System.Console.WriteLine("Select 5 for Supreme Pizza");
                        System.Console.WriteLine("Select 6 for Custom Pizza");
                        System.Console.WriteLine("Select 7 to see cart");
                        System.Console.WriteLine("Select 8 for Exit Pizza");
                        System.Console.WriteLine("Select 9 to read pizza file");
                        System.Console.WriteLine();

                        int select = 0; 
                        int.TryParse(Console.ReadLine(), out select);

                        switch(select)
                        {
                            case 1:
                                //var p = startup.CreatePizza("L","Stuffed", new List<string>{"Cheese"});
                                //cart.Add(p);
                                cart.CreatePizza("L","Stuffed", new List<string>{"Cheese"});
                                System.Console.WriteLine("Added Cheese Pizza");
                                break;
                            case 2:
                                cart.CreatePizza("L","Stuffed", new List<string>{"Pepperoni"});
                                System.Console.WriteLine("Added Pepperoni Pizza");
                                break;
                            case 3:
                                cart.CreatePizza("L","Stuffed", new List<string>{"Sausage"});
                                System.Console.WriteLine("Added Sausage Pizza");
                                break;
                            case 4:
                                cart.CreatePizza("L","Stuffed", new List<string>{"Tomato", "Olive","Green Peppers","Onion"});
                                System.Console.WriteLine("Added Vegetarian Pizza");
                                break;
                            case 5:
                                cart.CreatePizza("L","Stuffed", new List<string>{"Pepperoni","Sausage","Green Peppers","Onions"});
                                System.Console.WriteLine("Added Supreme Pizza");
                                break;
                            case 6:
                                cart.CreatePizza("L","Stuffed", new List<string>{"Custom"});
                                System.Console.WriteLine("Added Custom Pizza");
                                break;
                            case 7:
                                Console.WriteLine(cart.ShowCart());
                                break;
                            case 8:
                                exit = true;
                        }
                        System.Console.WriteLine("");
                    if (select < 7){
                        numPizzas++;
                    }

            }while(!exit);
            System.Console.WriteLine($"Thank you for ordering {numPizzas} pizzas");
            Console.WriteLine(cart.ShowCart());
        }


    }
}
