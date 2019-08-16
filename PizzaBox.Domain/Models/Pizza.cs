using System;

namespace PizzaBox.Domain.Models
{
    public class Pizza
    {
        public delegate Pizza PizzaFunc();

        //crust
        public string Crust {get; set;}

        //size
        public string Size {get; set;}

        //cost
        public double Price {get; set;}

        //2 default toppings
        //toppings limit 5
    }
}