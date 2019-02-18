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
        static int countList(int[] items)
        {
            if (items.Length == 0)
                return 0;
            else 
            {
                int[] newArray = items.Skip(1).Take(items.Length).ToArray();
                return 1 + countList(newArray);
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
