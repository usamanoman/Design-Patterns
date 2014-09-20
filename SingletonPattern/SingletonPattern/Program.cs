using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton cb;
        private int number;
        private Singleton()
        {
            number = 5;
        }
        public static Singleton getInstance()
        {
            if(cb == null){
                cb = new Singleton();
            }
            return cb;
        }

        public void setNumber(int num)
        {
            number = num;
        }
        public int getNumber()
        {
            return number;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();
            singleton.setNumber(8);
            Console.WriteLine(singleton.getNumber());
            Singleton abc = Singleton.getInstance();
            Console.WriteLine(abc.getNumber());

        }
    }
}
