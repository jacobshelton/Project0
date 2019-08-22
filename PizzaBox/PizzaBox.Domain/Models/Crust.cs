using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Crust : AComponent
    {
        public Crust(string name) : base(name)
        {
            switch(name)
            {
                case "Traditional American":
                    Price = 0.00;
                    break;

                case "Thin":
                    Price = 0.00;
                    break;

                case "Thick":
                    Price = 0.00;
                    break;

                case "Gluten Free":
                    Price = 2.00;
                    break;
            }
        }
    }
}