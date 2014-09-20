using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPTRN
{
    public interface Observer
    {
        void sendNotification(int temperature, int pressure, int humidity);
    }



    public class CurrentTemperature:Observer
    {
        public void sendNotification(int temperature, int pressure, int humidity)
        {
            Console.WriteLine("Temperature : " + temperature);
            
        }


    }



    public class CurrentPressure : Observer
    {
        public void sendNotification(int temperature, int pressure, int humidity)
        {
            Console.WriteLine("Pressure: " + pressure);
           
        }


    }



    public class CurrentHumidity : Observer
    {
        public void sendNotification(int temperature, int pressure, int humidity)
        {
            Console.WriteLine("Humidity : " + humidity);

        }


    }

}
