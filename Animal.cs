using System;

namespace animal
{
    public abstract class Animal
    {
        protected double weight { get; set; }
        protected string color { get; set; }
        
        public Animal()
        {
            this.weight = weight;
            this.color = color;
        }

        public abstract string makeSound();
        public abstract void printInfo();
    }

    public class Cat : Animal
    {
        private string name { get; set; }
        public Cat(double weight, string color, string name)
        {
            this.weight = weight;
            this.color = color;
            this.name = name;
        }
        public override void printInfo()
        {
            Console.WriteLine("Weight: {0}" + '\n' + "Color: {1}" + '\n' + "Name: {2}", this.weight, this.color, this.name);
        }

        public override string makeSound()
        {
            return "Meow";
        }        
    }

    public class Tiger : Animal
    {
        private string name { get; set; }
        public Tiger(double weight, string color, string name)
        {
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public override void printInfo()
        {
            Console.WriteLine("Weight: {0}" + '\n' + "Color: {1}" + '\n' + "Name: {2}", this.weight, this.color, this.name); Console.WriteLine("");
        }

        public override string makeSound()
        {
            return "Roar";
        }
    }

    public class Chicken : Animal, Edible
    {

        public Chicken(double weight, string color)
        {
            this.weight= weight;
            this.color = color;
        }

        public string HowToEat()
        {
            return "Chicken can be fried";
        }

        public override string makeSound()
        {
            return "cuck";
        }

        public override void printInfo()
        {
            Console.WriteLine("Weight: {0}" + '\n' + "Color: {1}" + '\n' + "Name: {2}", this.weight, this.color); Console.WriteLine("");
        }
    }
}

