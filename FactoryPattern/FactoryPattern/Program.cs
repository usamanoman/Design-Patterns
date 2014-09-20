using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory pf1 = new NYPizzaStore();
            PizzaFactory pf2 = new CaliforniaPizzaStore();
            pf1.orderPizza("spice");
            pf2.orderPizza("tikka");
        }
    }
}
