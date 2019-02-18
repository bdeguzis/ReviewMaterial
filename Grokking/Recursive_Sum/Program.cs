using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Sum
{
    class Program
    {

        //Given an array of integers, recursively find the sum

        static int recursiveSum (int[] nums)
        {
            if (nums == null)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            else
            {
                int[] newArray = nums.Skip(1).Take(nums.Length).ToArray();
                return nums[0] += recursiveSum(newArray);
            } 
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int[] nums2 = new int[] { 5 };

            Console.WriteLine(recursiveSum(nums));
            Console.WriteLine(recursiveSum(nums2));
            Console.ReadLine();
        }
    }
}
