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

        public static int[] TwoSumSortedArray(int[] nums, int target)
        {
            int first = 0;
            int last = nums.Length - 1;

            // for sorted array, start at outer index and move closer to middle until true.
            while (first<last)
            {
                if (nums[first] + nums[last] == target)
                {
                    return new int[] { nums[first], nums[last] };
                }
                else if (nums[first] + nums[last] < target)
                {
                    first++;
                }
                else
                {
                     last--;
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

        #region Multiply String

        // work in progress, quick first attempt using any method. will optimise later and not use biginteger.
        public string Multiply(string num1, string num2)
        {
            //Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
            //Input: num1 = "2", num2 = "3"
            //Output: "6"

            //The length of both num1 and num2 is < 110.
            //Both num1 and num2 contain only digits 0 - 9.
            //Both num1 and num2 do not contain any leading zero, except the number 0 itself.
            //You must not use any built-in BigInteger library or convert the inputs to integer directly**


            var number1 = System.Numerics.BigInteger.Parse(num1);
            var number2 = System.Numerics.BigInteger.Parse(num2);

            var x = number1 * number2;
            return x.ToString();
        }


        #endregion

        #region jewels

        /// <summary>
        /// Finds how many characters occur given two strings where one only contains distinct characters.
        /// </summary>
        /// <param name="Jewels">String containing distinct characters</param>
        /// <param name="Stones">String that will be checked for values in j</param>
        /// <returns></returns>
        public static int NumJewelsInStones(string Jewels, string Stones)
        {
            //given string "j" and "s";
            // J represents the types of stones that are jewels (JEWELS)
            // S represents the stones you have. (ALL STONES YOU HAVE)

            // each character in S is a type of stone you have.
            // You want to know how many of the stones you have are also jewels.

            // The letters in J are guaranteed DISTINCT, and all characters 
            // in J and S are letters. 
            // Letters are case sensitive,
            // so "a" is considered a different type of stone from "A".

            //** S & J have 50 letters max.
            // Characters in J are distinct.

            //eg input J = "aA", S = "aAAbbbb".
            // output = 3

            //eg2 Input: J = "z", S = "ZZ"
            // output = 0

            // spaces are also distinct

            //LOOP METHOD
            int count = 0;
            for (int i = 0; i < Jewels.Length; i++)
            {
                for (int j = 0; j < Stones.Length; j++)
                {
                    if (Jewels[i] == Stones[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int NumJewelsInStonesLINQ(string Jewels, string Stones)
        {
            // LINQ - Count of stones where Jewels contains a character in stones.
            return Stones.Count(c => Jewels.Contains(c));
        }

        #endregion

        #region Remove Vowels from string

        public static string RemoveVowelsFromString(string str)
        {
            string vowels = "aeiou";
            // new string, where str does not contain vowels, to array to return a string.
            return new string(str.Where(x => !vowels.Contains(x)).ToArray());         
        }

        #endregion


    }
}
