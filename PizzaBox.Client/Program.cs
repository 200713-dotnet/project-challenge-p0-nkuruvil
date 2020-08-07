using System;
using System.Collections.Generic;
using PizzaBox.Client;
using PizzaBox.Domain;
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
                    store.addOrder(order);
                    user.addOrder(order);
                    order.DateOrdered = DateTime.UtcNow;
                }else if(select == 2){
                    StoreExperience(store);
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

        static void StoreExperience(Store store)
        {
            Console.WriteLine("Store management. Select Option");

            Boolean exit = false;

            do{
                Console.WriteLine("1. View Store Orders");
                Console.WriteLine("2. Exit");

                int select = 0; 
                int.TryParse(Console.ReadLine(), out select);

                switch(select){
                    case 1:
                        Console.WriteLine("Order History");
                        Console.WriteLine(store.listOrders());
                        break;
                    case 2:
                        Console.WriteLine("Check complete");
                        exit = true;
                        break;
                }

            }while(!exit);
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

                        //Select Crust
                        System.Console.WriteLine("Select Crust");
                        System.Console.WriteLine("Select 1 for Pan");
                        System.Console.WriteLine("Select 2 for Thin-Crust");
                        System.Console.WriteLine("Select 3 for Stuffed");
                        Crust crust = new Crust();
                        int select = 0; 
                        int.TryParse(Console.ReadLine(), out select);
                        switch(select){
                            case 1:
                                crust.Name = "Pan";
                                break;
                            case 2:
                                crust.Name = "Thin-Crust";
                                break;
                            case 3:
                                crust.Name = "Stuffed";
                                break;
                            default:
                                crust.Name = "Pan";
                                break;
                        }
                        

                        //Select Size
                        System.Console.WriteLine("Select Size");
                        System.Console.WriteLine("Select 1 for Small");
                        System.Console.WriteLine("Select 2 for Medium");
                        System.Console.WriteLine("Select 3 for Large");
                        Size size = new Size();
                        select = 0; 
                        int.TryParse(Console.ReadLine(), out select);
                        switch(select){
                            case 1:
                                size.Name = "S";
                                size.Value = 6;
                                break;
                            case 2:
                                size.Name = "M";
                                size.Value = 10;
                                break;
                            case 3:
                                size.Name = "L";
                                size.Value = 12;
                                break;
                            default:
                                crust.Name = "Pan";
                                break;
                        }


                        List<Topping> toppings = new List<Topping>();

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

                        select = 0; 
                        int.TryParse(Console.ReadLine(), out select);

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
