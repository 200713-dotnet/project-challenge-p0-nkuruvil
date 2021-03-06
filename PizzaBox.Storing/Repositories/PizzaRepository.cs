using System.Collections.Generic;
using domain = PizzaBox.Domain;

namespace PizzaBox.Storing.Repositories
{
    public class PizzaRepository
    {

        //private PizzaBoxDbContext _db = new PizzaBoxDbContext();

        public void Create(domain.Pizza pizza){
            var newPizza = new domain.Pizza();

            newPizza.Crust = new domain.Crust() { Name = pizza.Crust.Name};
            newPizza.Size = new domain.Size() { Name = pizza.Size.Name};
            var orderDate = System.DateTime.UtcNow;
            //newPizza.DateModified = DateTime.Now;
            //newPizza.Active = false;
            //newPizza.UserModified = Indentity

            //_db.Pizza.Add(newPizza); //git add
            //_db.SaveChanges(); //git commit

        }
        
        /*public List<domain.Pizza> ReadAll(){

            // eager-loading
            // lazy-loading

            var domainPizzaList = new List<domain.Pizza>();

            var query = from p in _db.Pizza
                        select p;

            var pizzas = _db.Pizza;
            //var pizzaWithCrust = _db.Pizza.Include(this => this.Crust).Include()

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
        }*/

        public void Update(){

        }

        public void Delete(){

        }

    }
}