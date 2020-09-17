using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TwoSums
{
    class Program
    {
        static int[] TwoSums1(int[] nums, int target)
        {
            int[] ans = new int[2];
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }
            return ans;
        }

        //O(n)
        static int[] TwoSums2(int[] nums, int target)
        {
            if (nums.Length == 0) return nums;

            Hashtable hashnums = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                hashnums.Add(i, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];
                //does compliment exist in hashtable? if so, return this value
                //if (hashnums.ContainsValue(compliment)) return new int[] {i, hashnums.[]};
                if (hashnums.ContainsValue(compliment) && (int)hashnums[compliment] != i)
                {
                    var key = hashnums.Keys.OfType<int>().FirstOrDefault(s => (int)hashnums[s] == compliment);
                    return new int[] { key, i};
                }
            }
            int[] ans = new int[2];
            return ans;
        }

        static int[] TwoSums3(int[] nums, int target)
        {
            int[] ans = new int[2];
            return ans;
        }

        static void PrintAns(int[] ans)
        {
            foreach (int key in ans)
            {
                Console.Write("[" + key + "]");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] nums = new[] {2, 7, 11, 15};
            int [] ans1 = TwoSums1(nums, 9);
            int [] ans2 = TwoSums2(nums, 9); 
            int [] ans3 = TwoSums3(nums, 26);

            //PrintAns(ans1);
            PrintAns(ans2);
        }
    }
}
