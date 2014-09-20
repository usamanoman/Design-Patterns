using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternRightExample
{
    public interface Observer
    {
         void update(float temp, float pressure, float humidity);
    }

    class Forecast : Observer,DisplayElement
    {

        private float temp;
        private float pressure;
        private float humidity;
        private Subject WD;
        public Forecast(Subject WD)
        {
            this.WD = WD;
            this.WD.registerObserver(this);
        }
        public void update(float temp, float pressure,float humidity)
        {
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;
            this.display();
        }
        public void display()
        {
            Console.WriteLine("Temperature is " + this.temp + "\n Humidity is: " + this.humidity + "\n Pressure is : " + this.pressure);
        }
    }



    class CurrentData : Observer, DisplayElement
    {

        private float temp;
        private float pressure;
        private float humidity;
        private Subject WD;
        public CurrentData(Subject WD)
        {
            this.WD = WD;
            this.WD.registerObserver(this);
        }
        public void update(float temp, float pressure, float humidity)
        {
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;
            this.display();
        }
        public void display()
        {
            Console.WriteLine("Temperature is " + this.temp + "\n Humidity is: " + this.humidity + "\n Pressure is : " + this.pressure);
        }
    }





}
