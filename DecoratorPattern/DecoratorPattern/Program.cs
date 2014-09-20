using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Baverage b1 = new OrangeCoffee();
            Console.WriteLine(b1.cost());

            Baverage b2 = new DarkCoffee();
            b2 = new Mocha(b2);
            b2 = new Cream(b2);
            Console.WriteLine(b2.cost());
        }
    }
}
