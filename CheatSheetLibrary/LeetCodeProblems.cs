using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class LeetCodeProblems
    {

        #region TwoSum
        /// <summary>
        /// Takes in a array of numbers and finds two numbers in the array that add upto the target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            // my own words.
            // start with first element.
            // make second element++ and test agasint all numbers.
            // the target number - the first element = the second element.
            // return the i/j indexes. not elements.
            // else throw exception for no answer.
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        Console.WriteLine(nums[j] + " " + nums[i]);
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }

        /// <summary>
        /// A more optimised solution of TwoSum using a dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumDictionary(int[] nums, int target)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                // Uncomment this if nums are all positive
                //if (num > target) { continue; }

                if (numsDictionary.TryGetValue(target - num, out int index))
                {
                    Console.WriteLine($"{nums[index]},{nums[i]}");
                    return new[] { index, i };
                }

                numsDictionary[num] = i;
            }

            return nums;
        }
        #endregion

        #region Reverse Number

        public static int ReverseNumber(int x)
        {
            //Given a 32-bit signed integer, reverse digits of an integer.
            // -123 returns -321
            // 123 returns 321

            // check if valid int.
            if (x <= int.MinValue || x >= int.MaxValue)
            {
                return 0;
            }

            //check for negative
            bool isNegative = false;
            if (x < 0)
            {
                isNegative = true;
            }

            string revStr = ReverseString(x.ToString());

            if (isNegative)
            {
                revStr = revStr.Remove(revStr.Length - 1);
            }

            int revInt;
            try
            {
                revInt = Convert.ToInt32(revStr);
            }
            catch (Exception)
            {
                return 0;
            }

            if (isNegative)
            {
                return revInt * -1;
            }
            else
            {
                return revInt;
            }
        }

        public static string ReverseString(string str)
        {
            var cArr = str.ToCharArray();

            for (int start = 0, end = str.Length - 1; start < end; start++, end--)
            {

                cArr[start] = str[end];
                cArr[end] = str[start];

            }
            return new string(cArr);
        }

        /// <summary>
        /// A more optimised solution using less memory
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int reverseInt(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                // *10, then add last. e.g -456 => -6 *10 = -60 + -5 = -65 => -65 *10 = -650 + -4 = -654
                rev = rev * 10 + pop;
            }
            return rev;
        }
        #endregion
    }
}
