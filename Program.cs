using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Cat(5, "white", "Kurt");
            animals[1] = new Tiger(20, "orange", "Tiga");
            animals[2] = new Chicken(3, "orange");

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.makeSound());

                if(animal is Chicken)
                {
                    Edible edible = (Chicken)animal;
                    Console.WriteLine(edible.HowToEat());
                }
            }


            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
            Console.ReadKey();
        }
    }
}
