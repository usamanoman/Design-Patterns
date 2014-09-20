using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Baverage
    {
        public string desc = "I am parent of all baverages";
        public string getDescription()
        {
            return desc;
        }
        public abstract float cost();
        
    }


    class DarkCoffee : Baverage
    {
        public override float cost()
        {
            return (5.1F);
        }
        
    }

    class OrangeCoffee : Baverage
    {
        public override float cost()
        {
            return (2.3F);
        }
    }
}
