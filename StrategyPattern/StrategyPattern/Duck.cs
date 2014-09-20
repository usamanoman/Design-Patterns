using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected FlyBehaviour fb;
        protected QuackBehaviour q;
        public void performQuack()
        {
            q.quack();
        }
        public void performFly()
        {
            fb.fly();
        }
        public void swim()
        {
            Console.WriteLine("I can swim");
        }
        public abstract void display();

    }

    public class MarroldDuck : Duck
    {
        public MarroldDuck()
        {
            q = new CanQuack();
            fb = new CanFly();
        }
        public override void display()
        {
            Console.WriteLine("I am Marrold Duck");
        }

    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            q = new CanQuack();
            fb = new CanNotFly();
        }

        public override void display()
        {
            Console.WriteLine("I am Rubber Duck");
        }
    }
}
