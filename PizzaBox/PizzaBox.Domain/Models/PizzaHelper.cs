using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class PizzaHelper
    {
        //static List<Pizza> PizzaList = new List<Pizza>();
        //lists the Pizza's for the user to view
        //'Order' will allow this

    public static List<APizza> HandleOrder(string PizzaSelect, string CrustSelect, string SizeSelect, List<string> tops)
        {
            List<APizza> PizzaList = new List<APizza>();

            string crust = null;
            string size = null;

            switch (CrustSelect)
            {
                case "1":
                    crust = "Traditional American";
                    break;

                case "2":
                    crust = "Thin";
                    break;

                case "3":
                    crust = "Thick";
                    break;

                case "4":
                    crust = "Gluten Free";
                    break;
            }

            switch (SizeSelect)
            {
                case "1":
                    size = "10-inch";
                    break;

                case "2":
                    size = "12-inch";
                    break;

                case "3":
                    size = "14-inch";
                    break;

                case "4":
                    size = "16-inch";
                    break;
            }

            for(int i = 0; i < tops.Count; i++)
            {
                if (tops[i] == "1")
                    tops[i] = "Pepperoni";

                if (tops[i] == "2")
                    tops[i] = "Sausage";

                if (tops[i] == "3")
                    tops[i] = "Mushroom";
                
                if (tops[i] == "4")
                    tops[i] = "Onion";

                if (tops[i] == "5")
                    tops[i] = "Bell Pepper";

                if (tops[i] == "6")
                    tops[i] = "Bacon";
            }

            switch (PizzaSelect)
            {
                case "1":
                    PizzaList.Add(PizzaMaker.MakePizza(crust, size, tops));
                    break;

                case "2":
                    PizzaList.Add(PizzaMaker.MakeNewYorkPizza(tops));
                    break;
            }

            if (PizzaList.Count <= 100)
                return PizzaList;

            else
            {
                Console.WriteLine("WOW, you are trying to buy way too many pizzas... # of pizzas cannot exceed 100");
                return null;
            }
            

        }
    }
}