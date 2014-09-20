using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface Dough
    {
        void getDough();
    }

    public class ThinCrustDough : Dough
    {
        public void getDough()
        {

        }
    }
    public class ThickCrustDough : Dough
    {
        public void getDough()
        {
        }
    }
    public interface Vegie
    {
        void getVegie();
    }
    public class Onion : Vegie
    {
        public void getVegie()
        {
        }
    }
    public class Tomato : Vegie
    {
        public void getVegie()
        {
        }
    }
    public class Mustard : Vegie
    {
        public void getVegie()
        {
        }
    }
    public interface Cheese
    {
        void getCheese();
    }
    public class GoodCheese : Cheese
    {
        public void getCheese()
        {
        }
    }
    public class BadCheese : Cheese
    {
        public void getCheese()
        {
        }
    }
}
