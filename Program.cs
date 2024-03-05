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
            Cat cat = new Cat(5, "blue", "Mew");
            cat.printInfo();

            Console.ReadKey();
        }
    }
}
