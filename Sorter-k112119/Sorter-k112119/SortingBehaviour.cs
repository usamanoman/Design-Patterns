using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter_k112119
{
    public interface SortingBehaviour
    {
        List<int> sorting(List<int> inputList);
        
    }


    public class BubbleSorting : SortingBehaviour
    {

        public List<int> sorting(List<int> inputList)
        {
            Console.WriteLine("This is bubble sort");

            int[] inputArray = inputList.ToArray();
            //Console.WriteLine(inputArray.Length);
            int temp = 0;

            for (int write = 0; write < inputArray.Length; write++)
            {
                for (int sort = 0; sort < inputArray.Length - 1; sort++)
                {
                    if (inputArray[sort] > inputArray[sort + 1])
                    {
                        temp = inputArray[sort + 1];
                        inputArray[sort + 1] = inputArray[sort];
                        inputArray[sort] = temp;
                    }
                }
            }
            inputList = inputArray.ToList();
            return inputList;
        }
    }

   

    public class InsertionSorting : SortingBehaviour
    {
        public List<int> sorting(List<int> inputList)
        {
            Console.WriteLine("This is insertion sort");
            int[] inputArray = inputList.ToArray();

            for (int i = 1; i < inputArray.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
            }
            
            inputList = inputArray.ToList();
            return inputList;
        }
    }




}
