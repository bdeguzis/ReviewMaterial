using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {

        /*
          Selection sort takes a list of elements and starting at index 0 traverses the list comparing each value with the current index.
          If the value is smaller than the current index, than that index is saved. Once the entire list has been traversed, if a smaller value
          than the current index was found then they are swapped. The current index is then incremented to index 1 and the alogrithm repeats.       
         
          Due to selection sort being very inefficient for large amounts of data, it is usually only used for sorting small data sets. 

          Time Complexity:
            Best:    O(n^2)
            Average: O(n^2)
            Worst:   O(n^2)
        */


        static int[] selectionSort (int[] myArray)
        {
            int min_index;
            int temp;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                min_index = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[min_index])
                    {
                        min_index = j;                                     
                    }
                }
                if (min_index != i)
                {
                    temp = myArray[i];
                    myArray[i] = myArray[min_index];
                    myArray[min_index] = temp;
                }
            }
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] testArr = new int[] { 4, 1, 5, 0, 9, 1, 9, 2 };
            testArr = selectionSort(testArr);
            foreach (int i in testArr)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
