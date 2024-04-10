using System.Security.Cryptography.X509Certificates;

namespace animal
{
    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }

    public class Apple : Fruit
    {
        

        public override string HowToEat()
        {
            return "Apple can be sliced.";
        }
    }

    public class Orange : Fruit
    {
        

        public override string HowToEat()
        {
            return "Orange can be juiced";
        }
    }
}
