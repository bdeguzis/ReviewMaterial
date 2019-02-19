using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {

        /*
         
         Time Complexity:
            Best:    O(nlogn)
            Average: O(nlogn)
            Worst:   O(n^2)
        
        */


        static void quicksort(int[] nums, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
                return;

            int index = partition(nums, left, right);

            if (index != -1)
            {
                quicksort(nums, left, index - 1);
                quicksort(nums, index + 1, right);
            }

        }

        static int partition(int[] nums, int left, int right)
        {
            if (left > right)
                return -1;

            int end = left;

            int pivot = nums[right];
            for (int i = left; i < right; i++)
            {
                if (nums[i] < pivot)
                {
                    swap(nums, i, end);
                    end++;
                }
            }

            swap(nums, end, right);

            return end;
        }

        static void swap (int[] nums, int left, int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }

        static void Main(string[] args)
        {
            int[] myNums = new int[] { 7, 2, 1, 4, 3, 6 };
            quicksort(myNums, 0, myNums.Length - 1);
            foreach (int i in myNums)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
