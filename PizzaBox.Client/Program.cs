using System;
using System.Collections.Generic;
using PizzaBox.Client;
using PizzaBox.domain;
//using PizzaBox.Storing.Repositories;

namespace PizzaBox.client
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pr = new PizzaRepository();
            var pizza = new Pizza()
            {
                Crust = new Crust() {Name = "NY Style"},
                Size = new Size() {Name = "Medium"},
                Toppings = new List<Topping>(){new Topping("Cheese")}
            };



            //pr.Create(pizza);
            //Console.ReadLine();

            /*foreach(var item in pr.ReadAll())
            {
                System.Console.WriteLine(item);
            }*/

            
            int select = 0;
            var user = new User();
            var store = new Store();
            do{
                Console.WriteLine("Hello User!");
                Console.WriteLine("Select 1 for user, 2 for store, 0 to exit");
                int.TryParse(Console.ReadLine(), out select);
                if(select == 1){
                    Order order = new Order(store, user);
                    Menu(order);

                }else if(select == 2){

                }else if(select == 0){
                    Console.WriteLine("Thank you for using");
                }else{
                    Console.WriteLine("Invalid Number, please try again");
                    select = -1;
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
            if (order is null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            int numPizzas = 0;
            bool exit = false;
            var startup = new Startup();

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

                        Crust crust = new Crust();
                        crust.Name = "Stuffed";
                        Size size = new Size();
                        size.Name = "L";
                        size.Value = 12;
                        List<Topping> toppings = new List<Topping>();

                        switch(select)
                        {
                            case 1:
                                //var p = startup.CreatePizza("L","Stuffed", new List<string>{"Cheese"});
                                //cart.Add(p);
                                toppings.Add(new Topping("Cheese"));
                                System.Console.WriteLine("Added Cheese Pizza");
                                break;
                            case 2:
                                toppings.Add(new Topping("Pepperoni"));
                                System.Console.WriteLine("Added Pepperoni Pizza");
                                break;
                            case 3:
                                toppings.Add(new Topping("Sausage"));
                                System.Console.WriteLine("Added Sausage Pizza");
                                break;
                            case 4:
                                toppings.Add(new Topping("Tomato"));
                                toppings.Add(new Topping("Olive"));
                                System.Console.WriteLine("Added Vegetarian Pizza");
                                break;
                            case 5:
                                toppings.Add(new Topping("Pepperoni"));
                                toppings.Add(new Topping("Sausage"));
                                toppings.Add(new Topping("Green Pepper"));
                                toppings.Add(new Topping("Onion"));
                                //order.CreatePizza("L","Stuffed", new List<string>{"Pepperoni","Sausage","Green Peppers","Onions"});
                                System.Console.WriteLine("Added Supreme Pizza");
                                break;
                            case 6:
                                //order.CreatePizza("L","Stuffed", new List<string>{"Custom"});
                                toppings.Add(new Topping("cheese"));
                                System.Console.WriteLine("Added Custom Pizza: To be implemented");
                                break;
                            case 7:
                                Console.WriteLine(order.ShowCart());
                                break;
                            case 8:
                                exit = true;
                                break;
                        }
                        System.Console.WriteLine("");
                    if (select < 7){
                        order.addPizza(startup.createPizza(crust, size, toppings));
                        numPizzas++;
                    }

            }while(!exit);
            System.Console.WriteLine($"Thank you for ordering {numPizzas} pizzas");
            Console.WriteLine(order.ShowCart());
        }


    }
}
