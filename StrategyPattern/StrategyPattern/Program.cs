using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MarroldDuck();
            duck.display();
            duck.performQuack();
            duck.performFly();
            duck = new RubberDuck();
            duck.display();
            duck.performQuack();
            duck.performFly();
        }
    }
}
