using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SorterWithQuickSort
{
    class Sorter
    {
        public SortingBehaviour algorithm;
        public List<int> inputList = new List<int>();
        protected String complexity;

        
        
        public void performSort(){
            var watch = Stopwatch.StartNew(); 
            inputList = algorithm.sorting(inputList);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The time take to sort the array : " + elapsedMs + "ms");
            Console.Write("Sorted Output: ");
            displayList();
             
        }

        public String getComplexity()
        {
            return this.complexity;
        }
        
        
        public void  takeInput(){
            String read=null;
            int InputNumber;
            bool exitFlag=false;
            while(!exitFlag){
                read=Console.ReadLine();
                if (int.TryParse(read, out InputNumber))
                {
                    inputList.Add(InputNumber);
                }
                else
                {
                    exitFlag = true;
                }
                
            }

        }



        public void displayList()
        {
            foreach (int aNumber in inputList)
            {
                Console.Write(aNumber + " ");
            }
        }



        protected static void displayInputMessage()
        {
            Console.WriteLine("Please input series of integers, to exit press any character");

        }

    }


    class BubbleSort : Sorter
    {
        public BubbleSort()
        {
            algorithm = new BubbleSorting();
            displayInputMessage();
            this.complexity = "n-square";
            this.takeInput();
        }
    }


    class InsertionSort : Sorter
    {
        public  InsertionSort()
        {
            algorithm = new InsertionSorting();
            displayInputMessage();
            this.complexity = "n-square";
            this.takeInput();
        }

    }


    class QuickSort : Sorter
    {
        public QuickSort()
        {
            algorithm = new QuickSorting();
            displayInputMessage();
            this.complexity = "nlogn";
            this.takeInput();
        }

    }
    
        


    
}
