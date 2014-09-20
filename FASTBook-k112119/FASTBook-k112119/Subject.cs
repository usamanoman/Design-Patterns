using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASTBook_k112119
{
    public interface Subject
    {
         void registerObserver(Observer o);
         void removeObserver(Observer o);
         void notifyObservers();
    }

    public interface Comments
    {
        void getCommentsNotification(String message);
    }

    public class ConcreteSubjects : Subject,Comments
    {
        private String message;
        private String Name { get; set; }
        private List<Observer> PostObservers;
        public ConcreteSubjects(String name)
        {
            PostObservers = new List<Observer>();
            this.Name = name;            
        }
        public void registerObserver(Observer aObserver)
        {
            PostObservers.Add(aObserver);
        }
        public void removeObserver(Observer aObserver)
        {
            PostObservers.Remove(aObserver);
        }
        public void notifyObservers()
        {
            foreach (Observer o in PostObservers)
            {
                o.displayPost(this.message);
            }
        }

        public void postToWall(String message) {
            Console.WriteLine("Hello I am " + this.Name + ", I am sending every of my friends " + message);
            this.message = message;
            notifyObservers();
        }

        public void getCommentsNotification(String message)
        {
            Console.WriteLine("Hello I am " + this.Name + " ,I am get comment on my post, " + message);
            
        }
    }
}
