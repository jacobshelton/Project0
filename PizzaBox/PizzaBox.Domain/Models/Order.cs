using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
         //+ should be able to view its pizzas
        // - create a list of pizzas that the user adds to
        // - print the list
        public void View(List<APizza> PizzaList)
        {
            for(int i = 0; i < PizzaList.Count; i++)
            {
                Console.WriteLine(PizzaList[i].ToString());
            }
        }

        //+ should be able to compute its cost
        //  - x = (number of pizzas) * (Pizza.Crust.Price + Pizza.Toppings.Price)
        public void TotalPrice(List<APizza> PizzaList)
        {
            double Price = 0.0;

            for(int i = 0; i < PizzaList.Count; i++)
            {
                Price += PizzaList[i].Crust.Price + PizzaList[i].Size.Price; 
            }

            if (Price > 5000.0)
                Console.WriteLine("WOW, you are spending way too much money on pizzas... Price cannot exceed $5000");

            else
                Console.WriteLine(Price);
        }
     

        //+ should be able to limit its cost to no more than $5000
        // - x <= 5000

        //+ should be able to limit its pizza count to no more than 100
        // - (number of pizzas) <= 100
    }
}