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

        public abstract void printInfo();
    }

    public class Cat : Animal
    {
        private string name {  get; set; }
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
    }
}
