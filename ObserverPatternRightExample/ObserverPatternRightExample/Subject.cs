using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternRightExample
{
    public interface Subject
    {
         void registerObserver(Observer o);
         void removeObserver(Observer o);
         void notifyObserver();
    }

    class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature { get; set; }
        private float humidity { get; set; }
        private float pressure { get; set; }


        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);           
        }
        public void notifyObserver()
        {
            foreach(Observer observer in observers){
                observer.update(temperature,pressure,humidity);
            }
        }
        public void measurementsChanged()
        {
            notifyObserver();
        }
        public void setMeasurements(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
        
    }
}
