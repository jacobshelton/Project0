using System.Collections.Generic;
using PizzaBox.Domain.Abstract;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
    public class NewYork : APizza
    {
        public NewYork(List<Toppings> tops)
        {
                Crust = new Crust("thin");
                Size =  new Size("18-inch");
                Toppings = tops;
        }
    }
}