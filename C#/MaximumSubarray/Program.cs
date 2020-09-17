using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.

 

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.

Example 2:

Input: nums = [1]
Output: 1
 */
namespace MaximumSubarray
{
    class Program
    {
        static int MaximumSubarray(int[] nums)
        {
            int largestSum = int.MinValue;
            int last = nums.Length;
            int maxEndingHere = 0;

            //BRUTE FORCE METHOD
            //move front pointer every time until it meets the end 

            //once it met the end, move end ptr close to the front. and repeat
            for (int i = 0; i < last; i++)
            {
                maxEndingHere = maxEndingHere + nums[i];

                if (largestSum < maxEndingHere)
                    largestSum = maxEndingHere;

                if (maxEndingHere < 0)
                    maxEndingHere = 0;
            }

            return largestSum;
        }

        static void Main(string[] args)
        {
            int [] nums = new int[]{2,12,43,55,31,-12,-232,-0,10000};
            Console.WriteLine(MaximumSubarray(nums));
        }
    }
}
