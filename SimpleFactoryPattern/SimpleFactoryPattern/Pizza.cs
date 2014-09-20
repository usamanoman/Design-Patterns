using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class Pizza
    {
        public virtual void prepare()
        {
            Console.WriteLine("We are making pizza");
        }
        public void bake()
        {
            Console.WriteLine("We are backing pizza");

        }
        public void cut()
        {
            Console.WriteLine("We are cutting pizza");

        }
        public void box()
        {
            Console.WriteLine("We are boxing pizza");
        }
    }
    class PeproniPizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making peproni pizza");
        }
    }
    class SpicePizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making spice pizza");
        }
    }

}
