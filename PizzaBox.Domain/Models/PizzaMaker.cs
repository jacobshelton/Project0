using System;

namespace PizzaBox.Domain.Models
{
    public class PizzaMaker
    {
        public Pizza MakePizza(Pizza.PizzaFunc pizza)
        {
            return pizza();
        }
    }
}