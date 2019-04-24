using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class LeetCodeProblems
    {


        /// <summary>
        /// Takes in a array of numbers and finds two numbers in the array that add upto the target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        Console.WriteLine(nums[j] + " " + nums[i]);
                        var a = new int[] { i, j };
                        return a;

                    }
                }
            }
            throw new Exception("No two sum solution");
        }

    }
}
