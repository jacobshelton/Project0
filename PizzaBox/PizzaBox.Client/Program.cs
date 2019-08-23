using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            /*List<Toppings> tops = new List<Toppings>();

            Toppings sausage = new Toppings("Sausage");
            Toppings pepperoni = new Toppings("Pepperoni");
            Toppings mushroom = new Toppings("Mushroom");

            tops.Add(sausage);
            tops.Add(pepperoni);
            tops.Add(mushroom);*/

            UI();
            

            //Console.WriteLine(PizzaMaker.MakeNewYorkPizza(tops).ToString());

        }

        static void UI()
        {
            List<APizza> PizzaList = new List<APizza>();

            string SignInSelect;
            string Username;
            string UserDecision;
            string PizzaSelect;
            string CrustSelect = null;
            string SizeSelect = null;

            List<string> ToppingSelect = new List<string>();

            //Registe/Sign In
            Console.WriteLine("If you have an account, please sign in. If not, please register");
            Console.WriteLine("1 = Sign In, 2 = Register");
            
            SignInSelect = Console.ReadLine();

            if (SignInSelect == "1")
            {
                Console.Write("Username: ");
                Username = Console.ReadLine();
                //grab user from the database
            }

            if (SignInSelect == "2")
            {
                Console.Write("Create Username: ");
                Username = Console.ReadLine();
                User user = new User
                {
                    Name = Username
                    //add to database
                };
            }

            //Account Access
            Console.WriteLine("1 = Order Pizza, 2 = My Account");

            UserDecision = Console.ReadLine();

            if (UserDecision == "2")
            {
                //order history
                //signout
                Console.WriteLine("1 = Order Pizza, 2 = Signout");
                UserDecision = Console.ReadLine();
            }

            Order order = new Order();

            while (UserDecision == "1")
            {

                //Select Pizza
                Console.WriteLine("Please select a specialty or create your own pizza:");
                Console.WriteLine("1 = Create Your Own! (choose the crust, size, and toppings)");
                Console.WriteLine("2 = New York (18-inch thin crust pizza with your desired toppings)");

                PizzaSelect = Console.ReadLine();

                //Select Crust
                if(PizzaSelect == "1") 
                {
                    Console.WriteLine("Please select the style of crust:");
                    Console.WriteLine("1 = Traditional American(the crust you know and love), 2 = Thin, 3 = Thick, 4 = Gluten Free");

                    CrustSelect = Console.ReadLine();

                    //Select Size
                    Console.WriteLine("Please select the size:");
                    Console.WriteLine("1 = 10-inch, 2 = 12-inch, 3 = 14-inch, 4 = 16-inch");

                    SizeSelect = Console.ReadLine();
                }

                //Select Toppings
                Console.WriteLine("Please select up to 5 toppings from the list:");
                while (ToppingSelect.Count < 5)
                {
                    Console.WriteLine("1 = Pepperoni, 2 = Sausage, 3 = Onion, 4 = Mushroom, 5 = Bell Pepper, 6 = Bacon");
                    Console.WriteLine("0 = Done");
                    string temp = Console.ReadLine();

                    if (temp == "0")
                        break;
                    else
                        ToppingSelect.Add(temp);
                }

                //Send Info to PizzaHelper
                PizzaList.AddRange(PizzaHelper.HandleOrder(PizzaSelect, CrustSelect, SizeSelect, ToppingSelect));

                Console.WriteLine("1 = Add another pizza, 2 = View Order, 3 = Confirm Order");

                UserDecision = Console.ReadLine();

                if (UserDecision == "2")
                {
                    order.View(PizzaList);
                    order.TotalPrice(PizzaList);

                    Console.WriteLine("1 = Add another pizza, 3 = Confirm Order");

                    UserDecision = Console.ReadLine();
                }

                if (UserDecision == "3")
                {
                    //add order to database
                    //end the program
                }
            }
        }


        
    }
}
