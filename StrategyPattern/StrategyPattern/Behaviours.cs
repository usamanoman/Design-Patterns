using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface FlyBehaviour
    {
        void fly();
    }

    public class CanFly : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I am fly");
        }
    }

    public class CanNotFly : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }


    public interface QuackBehaviour
    {
        void quack();
    }


    public class CanQuack: QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I can quack");
        }
    }

    public class CantQuack : QuackBehaviour
    {
        public  void quack()
        {
            Console.WriteLine("I can't quack");
        }
    }
}
