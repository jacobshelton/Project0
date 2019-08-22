using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Toppings : AComponent
    {
        public Toppings(string name) : base(name){}
    }
}