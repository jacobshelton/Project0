namespace PizzaBox.Domain.Abstract
{
    public abstract class AComponent
    {
        public string Name {get; set;}
        public double Price {get; set;}

        public AComponent(string name) 
        {
            Name = name;
        }
    }
}