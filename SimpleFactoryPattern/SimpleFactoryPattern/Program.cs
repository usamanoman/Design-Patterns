using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfPizza = "spice";
            SimplePizzaFactory sf=new SimplePizzaFactory();
            PizzaStore ps = new PizzaStore(sf);
            ps.orderPizza(typeOfPizza);
        }
    }
}
