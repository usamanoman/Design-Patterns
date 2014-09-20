using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
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
    class NYPeproniPizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making new york styled peproni pizza");
        }
    }
    class NYSpicePizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making new york styled spice pizza");
        }
    }
    class NYTikkaPizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making new york styled tikka pizza");
        }
    }

    class CalPeproniPizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making california styled peproni pizza");
        }
    }
    class CalTikkaPizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making california styled tikka pizza");
        }
    }
    class CalSpicePizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("We are making california styled spice pizza");
        }
    }


}
