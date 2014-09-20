using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASTBook_k112119
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubjects myS = new ConcreteSubjects("P1"); //Making a subject
            ConcreteObservers myOb = new ConcreteObservers(myS,"P2"); //Making an observer
            ConcreteObservers myOb2 = new ConcreteObservers(myS, "P3"); //Making an observer
            
            
            myOb2.registerObserver(myOb); //observer1 is friend with observer2
            myS.postToWall("Good Morning!"); //Subject post on wall, every of his observers(friends) are notified
            myOb2.comment("Good Noon"); //Observer2 comment and his friends,himself, and authors are notified.
            
        }
    }
}
