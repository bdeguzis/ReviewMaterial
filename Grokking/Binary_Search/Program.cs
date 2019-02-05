using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {

        /*
         Binary Search takes a list of ordered elements and finds the desired element by dividing the list in half on the midpoint. 
         This process is repeated for the half that has the desired element depending on if the midpoint was higher or lower than 
         than said element. Repeat until the element is found or not.
         
         Search Time:
            Best Case:  O(1)
            Worst Case: O(log n)  
        */


        private static int binary_search(int[] myList, int num)
        {
            if (myList == null)
                return -1; //null case

            int low = 0;
            int high = myList.Length - 1;
            int mid = (low + high) / 2;
            int guess = myList[mid];
            
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = myList[mid];
                if (guess == num)
                    return mid;
                if (guess < num)
                    low = mid + 1;
                else if (guess > num)
                    high = mid - 1;
                
            }
            return -2; //not found
        }

        static void Main(string[] args)
        {
            int[] myNums = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] myNullNums = null;
            Console.WriteLine(binary_search(myNums, 4));
            Console.WriteLine(binary_search(myNums, 6));
            Console.WriteLine(binary_search(myNums, 1));
            Console.WriteLine(binary_search(myNums, 0));
            Console.WriteLine(binary_search(myNullNums, 1));
            Console.ReadLine();

        }
    }
}
