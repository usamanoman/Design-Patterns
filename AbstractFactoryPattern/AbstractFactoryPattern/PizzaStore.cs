using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class PizzaStore
    {


        public void orderPizza(string param)
        {
            Pizza pizza = createPizza(param);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }
        public abstract Pizza createPizza(string typeOfPizza);
    }


    public class NYPizzaStore : PizzaStore
    {
        IngrediantFactory ing = new NYIngrediantFactory();
        public override Pizza createPizza(string param)
        {
            Pizza pizza = null;
            if (param == "cheese")
            {
                pizza = new CheesePizza(ing);
                pizza.name = "NY Cheese";
            }
            else if (param == "spice")
            {
                pizza = new SpicePizza(ing);
                pizza.name = "NY Spice";
            }
            return pizza;
        }
    }
    public class CaliPizzaStore : PizzaStore
    {
        IngrediantFactory ing = new CaliIngrediantFactory();
        public override Pizza createPizza(string param)
        {
            Pizza pizza = null;
            if (param == "cheese")
            {
                pizza = new CheesePizza(ing);
                pizza.name = "CAL Cheese";
            }
            else if (param == "spice")
            {
                pizza = new SpicePizza(ing);
                pizza.name = "CAL Spice";
            }
            return pizza;
        }
    }


}
