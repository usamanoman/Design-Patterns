using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaFactory
    {
        public void orderPizza(string param)
        {
            Pizza pizza;
            pizza = createPizza(param);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }
        public  abstract Pizza createPizza(string param);
    }

    public class NYPizzaStore:PizzaFactory
    {
        public override Pizza createPizza(string param)
        {
            Pizza pizza = null;
            if (param == "spice")
            {
                return new NYSpicePizza();
            }
            else if (param == "tikka")
            {
                return new NYTikkaPizza();
            }
            else if (param == "peproni")
            {
                return new NYPeproniPizza();
            }
            return pizza;
        }
    }


    public class CaliforniaPizzaStore : PizzaFactory
    {
        public override Pizza createPizza(string param)
        {
            Pizza pizza = null;
            if (param == "spice")
            {
                return new CalSpicePizza();
            }
            else if (param == "tikka")
            {
                return new CalTikkaPizza();
            }
            else if (param == "peproni")
            {
                return new CalPeproniPizza();
            }
            return pizza;
        }
    }
}
