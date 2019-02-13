using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoneNumber
{
    class Program
    {
        //Given a non-empty array of integers, every element appears twice except for one. Find that single one.
        public static int singleNumber(int[] nums)
        {
            int counter = 0;
            int a, b;
            for (int i = 1; i < nums.Length; i++)
            {
                a = nums[counter];
                b = nums[i];
                if (counter == nums.Length - 1)
                    return nums[counter];
                if (i == counter)
                    continue;
                else if (nums[i] == nums[counter])
                {
                    counter++;
                    i = -1;
                }

            }

            return nums[counter];       
        }    

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 0, 1};
            Console.WriteLine(singleNumber(nums));
            Console.ReadLine();
        }
    }
}
