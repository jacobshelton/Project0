using System;
using System.Collections.Generic;
using PizzaBox.Domain.Recipes;
using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public static class PizzaMaker
    {
        public static APizza MakePizza(string crust, string size, List<string> tops)
        {
            Crust madeCrust = new Crust(crust);
            Size madeSize = new Size(size);

            List<Toppings> toppings = new List<Toppings>();
            for(int i = 0; i < tops.Count; i++)
            {
                toppings.Add(GetTopping(tops[i]));
            }

            var pizza = new Pizza(madeCrust, madeSize, toppings);

            return pizza;
        }

        public static APizza MakeNewYorkPizza(List<string> tops)
        {
            List<Toppings> toppings = new List<Toppings>();
            for(int i = 0; i < tops.Count; i++)
            {
                toppings.Add(GetTopping(tops[i]));
            }

            var NY = new NewYork(toppings);

            return NY;
        }

        public static APizza MakeChicagoPizza(List<Toppings> tops)
        {
            return null;
        }

        public static APizza MakeHawaiianPizza(List<Toppings> tops)
        {
            return null;
        }

        public static Toppings GetTopping(string topping)
        {
            Toppings top = new Toppings(topping);

            return top;
        }
    }
}