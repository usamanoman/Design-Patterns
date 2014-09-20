using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateBoilerSingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler cb = ChocolateBoiler.getInstance();
            cb.fill();
            cb.boilMethod();
            //cb.drain();
            ChocolateBoiler bc = ChocolateBoiler.getInstance();
            bc.fill();
        }
    }
}
