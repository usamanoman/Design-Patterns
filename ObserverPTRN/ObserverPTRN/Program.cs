using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPTRN
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subj = new ConcreteSubject();
            Observer obs1 = new CurrentTemperature();
            Observer obs2 = new CurrentPressure();
            subj.RegisterObserver(obs1);
            subj.RegisterObserver(obs2);
            subj.setMeasurement((int)5, (int)6, (int)9);
            subj.BlockObserver(obs2);
            subj.setMeasurement((int)8, (int)14, (int)20);
            

        }
    }
}
