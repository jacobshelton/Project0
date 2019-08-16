using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class PizzaHelper
    {
        static List<string> PizzaComponents = new List<string>();
        //lists the Pizza's components to send to the PizzaMaker

        static List<Pizza> PizzaList = new List<Pizza>();
        //lists the Pizza's for the user to view
        //'Order' will allow this

        public static void HandleCrustSelect(string CrustSelect)
        {
            switch (CrustSelect)
            {
                case "1":
                    Console.WriteLine("New York");
                    PizzaComponents.Add("New York");
                    break;

                case "2":
                    Console.WriteLine("Chicago");
                    PizzaComponents.Add("Chicago");
                    //ChicagoStyle();
                    break;

                case "3":
                    Console.WriteLine("Traditional American");
                    PizzaComponents.Add("Traditional American");
                    //TraditionalAmerican();
                    break;
            }
        }

        public static void HandleSizeSelect(string SizeSelect)
        {
            switch (SizeSelect)
            {
                case "1":
                    Console.WriteLine("Small");
                    PizzaComponents.Add("Small");
                    //Small();
                    break;

                case "2":
                    Console.WriteLine("Medium");
                    PizzaComponents.Add("Medium");
                    //Medium();
                    break;

                case "3":
                    Console.WriteLine("Large");
                    PizzaComponents.Add("Large");
                    //Large();
                    break;

                case "4":
                    Console.WriteLine("Extra Large");
                    PizzaComponents.Add("Extra Large");
                    //ExtraLarge();
                    break;
            }
        }

        public static void HandleToppingSelect(string ToppingSelect)
        {
            //I don't know the best way to do this...
            //switch statement would be ridiculous
        }
    }
}