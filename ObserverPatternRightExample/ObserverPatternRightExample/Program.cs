using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternRightExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();
            Forecast fc = new Forecast(wd);
            wd.setMeasurements((float)10.3, (float)23.4, (float)98.0);

        }
    }
}
