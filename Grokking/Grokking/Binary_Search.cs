using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    class Binary_Search
    {
        private static int binary_search(int[] myList, int num)
        {
            int low = 0;
            int high = myList.Length - 1;
            int mid = (low + high) / 2;
            int guess = myList[mid];
            if (myList == null)
                return -1; //null case
            while (myList[guess] != num)
            {
                if (myList[guess] < num)
                    low = guess + 1;
                else if (myList[guess] > num)
                    high = guess - 1;
                else if (myList[guess] == num)
                    return guess;
            }
            return -1; //null case
        }

        static void Main(string[] args)
        {
            int[] myNums = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(binary_search(myNums, 2));
            Console.ReadLine();
        }

        
    }
}
