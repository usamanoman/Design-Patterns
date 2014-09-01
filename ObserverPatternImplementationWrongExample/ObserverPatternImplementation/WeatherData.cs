using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternImplementation
{

    class currentCondition
    {
        public void display(int temp, int press, int hum)
        {

        }
    }

    class forecastCondition
    {
        public void display(int temp, int press, int hum)
        {

        }
    }

    class statistis
    {
        public void display(int temp, int press, int hum)
        {

        }
    }



    class WeatherData
    {
        public int temperature;
        public int humidity;
        public int pressure;

        

        public void measurementsChanged()
        {
            this.temperature = getTemparature();
            this.humidity = getHumidity();
            this.pressure = getPressure();
            currentCondition currentCond = new currentCondition();
            forecastCondition forecast = new forecastCondition();
            statistis statistical = new statistis();

            currentCond.display(temperature,  pressure,humidity);
            statistical.display(temperature, pressure, humidity);
            forecast.display(temperature, pressure, humidity);




        }
    }
}
