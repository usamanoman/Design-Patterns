using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IngrediantFactory
    {
        Dough createDough();
        Vegie[] createVegie();
        Cheese createCheese();
    }

    public class NYIngrediantFactory : IngrediantFactory
    {
        public Dough createDough()
        {
            return new ThickCrustDough();
        }
        public Vegie[] createVegie()
        {
            Vegie[] vg = { new Mustard(), new Onion() };
            return vg;
        }
        public Cheese createCheese()
        {
            return new BadCheese();
        }
    }
    public class CaliIngrediantFactory : IngrediantFactory
    {
        public Dough createDough()
        {
            return new ThinCrustDough();
        }
        public Vegie[] createVegie()
        {
            Vegie[] vg = { new Tomato(), new Onion() };
            return vg;
        }
        public Cheese createCheese()
        {
            return new GoodCheese();
        }
    }
}
