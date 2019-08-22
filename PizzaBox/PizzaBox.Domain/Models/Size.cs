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
                    Price = 10.00;
                    break;

                case "12-inch":
                    Price = 12.00;
                    break;

                case "14-inch":
                    Price = 14.00;
                    break;

                case "16-inch":
                    Price = 16.00;
                    break;
            }
        }
    }
}