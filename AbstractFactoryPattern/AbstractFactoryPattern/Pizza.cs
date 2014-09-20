using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract  class Pizza
    {
        public Dough dough;
        public Cheese cheese;
        public Vegie[] vegie;

        public string name { get; set; }
        public abstract void prepare();
        public void bake()
        {
            Console.WriteLine("We are baking cake " ); 
        }
        public void cut()
        {
            Console.WriteLine("We are cutting cake  " );
        }
        public void box()
        {
            Console.WriteLine("We are boxing cake  " );
        }
        
    }

 
    public class SpicePizza : Pizza
    {
        IngrediantFactory ingF ;
        public SpicePizza(IngrediantFactory ingF)
        {
            this.ingF = ingF;
            
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing  : " + this.name);
            dough = this.ingF.createDough();
            cheese = this.ingF.createCheese();
            vegie = this.ingF.createVegie();

        }
    }
    public class CheesePizza : Pizza
    {
        IngrediantFactory ingF ;
        public CheesePizza(IngrediantFactory ingF)
        {
            this.ingF = ingF;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing  : " + this.name);
            dough = this.ingF.createDough();
            cheese = this.ingF.createCheese();
            vegie = this.ingF.createVegie();

        }
    }
    public class Calm : Pizza
    {
        IngrediantFactory ingF ;
        public Calm(IngrediantFactory ingF)
        {
            this.ingF = ingF;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing  : " + this.name);
            dough = this.ingF.createDough();
            cheese = this.ingF.createCheese();
            vegie = this.ingF.createVegie();

        }
    }
}
