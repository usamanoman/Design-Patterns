using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterWithQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Sorter aSorter = new Sorter();
            aSorter=displayMenu(aSorter);
            String typeOfObj = aSorter.GetType().ToString();
            if (typeOfObj == "Sorter_k112119.Sorter")
                Console.WriteLine("Wrong Choice");
            else
            {
                aSorter.performSort();
                Console.WriteLine(aSorter.getComplexity());
            }
            
              
        }

        
        public static Sorter displayMenu(Sorter aSorter)
        {
            Console.WriteLine("Select Options");
            Console.WriteLine("1- Bubble Sort");
            Console.WriteLine("2- Insertion Sort");
            Console.WriteLine("3- Quick Sort");
            String selectionString = Console.ReadLine();
            int InputNumber;
            int.TryParse(selectionString, out InputNumber);
            switch (InputNumber)
            {
                case 1:
                    aSorter = new BubbleSort();
                    break;
                case 2:
                    aSorter = new InsertionSort();
                    break;
                case 3:
                    aSorter = new QuickSort();
                    break;
            }

            return aSorter;
        }
    }
}
