using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UI();
        }


        static void UI()
        {
            string CrustSelect;

            Console.WriteLine("Please select the style of crust:");
            Console.WriteLine("New York = 1, Chicago = 2, or Traditional American = 3");

            CrustSelect = Console.ReadLine();

            PizzaHelper.HandleCrustSelect(CrustSelect); //PizzaHelper


            string SizeSelect;

            Console.WriteLine("Please select the size:");
            Console.WriteLine("$4 SM = 1, $6 MED = 2, $8 L = 3, $10 XL = 4");
            SizeSelect = Console.ReadLine();

            PizzaHelper.HandleSizeSelect(SizeSelect); //PizzaHelper


            string ToppingSelect;

            Console.WriteLine("Please select from the list of toppings we have in store:");
            Console.WriteLine("Pepperoni = 1, Sausage = 2, Peppers = 3, Mushrooms = 4, Bacon = 5");
            ToppingSelect = Console.ReadLine();

            PizzaHelper.HandleToppingSelect(ToppingSelect); //PizzaHelper
        }


        
    }
}
