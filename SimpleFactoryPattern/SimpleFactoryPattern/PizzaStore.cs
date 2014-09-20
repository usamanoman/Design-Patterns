using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class PizzaStore
    {
        SimplePizzaFactory pizzaFactory;
        public PizzaStore(SimplePizzaFactory pf){
            pizzaFactory= pf;
        }

        public void orderPizza(string param)
        {
            Pizza pizza;
            pizza = pizzaFactory.createPizza(param);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }
    }

    public class SimplePizzaFactory{
        public Pizza createPizza(string param){
            Pizza pizza=null;
            if (param == "peproni")
            pizza=new PeproniPizza();
            else if(param=="spice")
            pizza=new SpicePizza();
            return pizza;
        }

    }
}
