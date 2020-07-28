using System.Collections.Generic;
using domain = PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
    public class PizzaRepository
    {

        private PizzaBoxDbContext _db = new PizzaBoxDbContext();

        public void Create(domain.Pizza pizza){
            var newPizza = new Pizza();

            newPizza.Crust = new Crust() { Name = pizza.Crust.Name};
            newPizza.Size = new Size() { Name = pizza.Size.Name};
            newPizza.Name = pizza.Name;
            var orderDate = System.DateTime.UtcNow;
            //newPizza.DateModified = DateTime.Now;
            //newPizza.Active = false;
            //newPizza.UserModified = Indentity

            _db.Pizza.Add(newPizza); //git add
            _db.SaveChanges(); //git commit

        }
        
        public List<domain.Pizza> ReadAll(){
            var domainPizzaList = new List<domain.Pizza>();
            foreach(var item in _db.Pizza.ToList())
            {
                domainPizzaList.Add(new domain.Pizza(){
                    Crust = new domain.Crust() { Name = item.Crust.Name},
                    Size = new domain.Size() { Name = item.Size.Name},
                    Toppings = new List<domain.Topping>(),
                    Name = item.Name
                });
            }
            return domainPizzaList; //
        }

        public void Update(){

        }

        public void Delete(){

        }

    }
}