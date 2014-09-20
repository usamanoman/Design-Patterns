using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateBoilerSingletonExample
{
    public class ChocolateBoiler
    {
        public bool empty { get; set; }
        public bool boil { get; set; }
        private static ChocolateBoiler cber;
        private  ChocolateBoiler()
        {
            this.empty = true;
            this.boil = true;

        }
        public static ChocolateBoiler getInstance()
        {
            if (cber == null)
            {
                cber = new ChocolateBoiler();
            }
            return cber;
        }
        public void fill()
        {
            if (this.empty == true)
            {
                this.empty = false;
                this.boil = false;
                Console.WriteLine("The boiler is full");

            }
        }

        public void drain()
        {
            if (this.empty == false && this.boil == true)
            {
                this.empty = true;
                this.boil = true;
                Console.WriteLine("The boiler is drain");
            }
        }
        public void boilMethod()
        {
            if (this.boil == false && this.empty==false)
            {
                this.boil = true;
                Console.WriteLine("The boiler is boiled");

            }
        }
    }
}
