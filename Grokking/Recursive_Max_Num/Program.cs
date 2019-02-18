using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Max_Num
{
    class Program
    {

        //Recursively find the max number in a list

        static int max = 0;
        static int maxNum (int[] nums)
        {
            if (nums.Length == 0)
                return max;
            else
            {

                if (nums[0] > max)
                    max = nums[0];

                int[] newArray = nums.Skip(1).Take(nums.Length).ToArray();
                return maxNum(newArray);
            }
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 10, 4, 5 };
            Console.WriteLine(maxNum(nums));
            Console.ReadLine();
        }
    }
}
