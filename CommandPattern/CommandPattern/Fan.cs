using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Fan
    {
        public int Speed { get; protected set; }
        public void on()
        {
            Console.WriteLine("Fan is on");
            Speed = 1;
        }
        public void off()
        {
            Console.WriteLine("Fan is off");
            Speed = 0;
        }

        public void medium()
        {
            Console.WriteLine("Fan is medium");
            Speed = 2;
        }

        public void high()
        {
            Console.WriteLine("Fan is high");
            Speed = 3;
        }

    }
}
