using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Size : AComponent
    {
        public Size(string name) : base(name)
        {
            switch (name)
            {
                case "10-inch":
                    Price = 9.99;
                    break;

                case "12-inch":
                    Price = 11.99;
                    break;

                case "14-inch":
                    Price = 13.99;
                    break;

                case "16-inch":
                    Price = 15.99;
                    break;

                case "18-inch":
                    Price = 17.99;
                    break;
            }
        }
    }
}