using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASTBook_k112119
{
    public interface Observer
    {

        void displayPost(String message);
    }

    public class ConcreteObservers : Observer,Comments,Subject
    {
        private List<Observer> obsList;
        private ConcreteSubjects PostAuthor;
        private String Name { get; set; }
        private String message;
        public ConcreteObservers(ConcreteSubjects aSubject, String name)
        {
            obsList = new List<Observer>();
            PostAuthor = aSubject;
            PostAuthor.registerObserver(this);
            this.Name = name;
        }
        public void displayPost(String message) {
            Console.WriteLine("I am " + this.Name +" I recieve "+ message);
        }

        public void registerObserver(Observer a)
        {
            obsList.Add(a);
        }

        public void removeObserver(Observer a)
        {
            obsList.Remove(a);
        }


        public void notifyObservers()
        {
            foreach (Observer a in obsList)
            {
                a.displayPost(this.message);
            }
        }
        

        public void comment(String message)
        {
            this.message = message;
            PostAuthor.getCommentsNotification(this.message);
            this.getCommentsNotification(this.message);
            this.notifyObservers();
        }

        public void getCommentsNotification(String message)
        {
            Console.WriteLine("Hello I am " + this.Name + " ,I commented , " + this.message);

        }
    }
}
