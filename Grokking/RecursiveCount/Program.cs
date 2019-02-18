using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCount
{
    class Program
    {
        //Write a recursive function to count the number of items in a list.
        static int count = 0;
        static int countList(int[] items)
        {
            if (items.Length == 0)
                return count;
            else 
            {
                count++;
                int[] newArray = items.Skip(1).Take(items.Length).ToArray();
                return countList(newArray);
            }

        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(countList(nums));
            Console.ReadLine();
        }
    }
}
