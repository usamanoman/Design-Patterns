using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPTRN
{
    public interface Subject
    {
        void RegisterObserver(Observer Obsitem);
        void NotifyObserver();
        void BlockObserver(Observer Obsitem);

    }

    public class ConcreteSubject:Subject
    {
        public int temperature;
        public int humidity;
        public int presure;
        public List<Observer> obs;
        public ConcreteSubject()
        {
            obs = new List<Observer>();
        }
        public void RegisterObserver(Observer Obsitem)
        {
            obs.Add(Obsitem);
        }
        public void BlockObserver(Observer Obsitem)
        {
            obs.Remove(Obsitem);
        }
        public void NotifyObserver()
        {
            foreach (Observer obsvr in obs)
            {
                obsvr.sendNotification(this.temperature, this.presure, this.humidity);
            }
        }

        public void setMeasurement(int temperature, int pressure, int humidity)
        {
            this.temperature = temperature;
            this.presure= pressure;
            this.humidity = humidity;
            this.NotifyObserver();

        }
    }
}
