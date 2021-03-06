﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class InterviewQuestions
    {
        public static void FizzBuzzBasicIf()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void FizzBuzzStringConcat()
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = string.Empty;
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (output == string.Empty)
                {
                    output += i.ToString();
                }
                Console.WriteLine(output);
            }

        }

        public static bool PalindromeCheck(string str)
        {
            //check if the word is the same backwards.
            //check if last index is same as first index.

            //get the reversed string;

            string myString = str.ToLower();

            for (int i = 0; i < myString.Length / 2; i++)
            {
                if (myString[i] != myString[myString.Length - i - 1])
                {
                    Console.WriteLine(myString[myString.Length - i - 1]);
                    return false;
                }
            }
            return true;
        }

        public static void ReverseStringV1(string str)
        {
            //chart array.
            var chArray = str.ToCharArray();

            //passed in value.
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                //swap.
                chArray[i] = str[j];
                chArray[j] = str[i];
            }
            var x = new string(chArray);
            Console.WriteLine(x);


        }

        public static void ReverseStringV2(string str)
        {
            var cArr = str.ToCharArray();

            for (int start = 0, end = str.Length - 1; start < end; start++, end--)
            {

                cArr[start] = str[end];
                cArr[end] = str[start];

            }
            var oneString = new string(cArr);

            Console.WriteLine(oneString);
        }

        public static void FIXXXXXSumOfPrimesBetweenTwoNumbers(int min, int max)
        {
            //Given two numbers, find the sum of prime numbers between them, both inclusive.
            //Print the sum of prime numbers
            //input 1,5. output 10;
            List<int> li = new List<int>();


            var counter = 0;
            //goes through numbers 1-5
            for (int i = min; i < max + 1; i++)
            {
                //check if the number is prime.

                for (int j = min; j <= max; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    li.Add(i);
                }
                else
                {
                    Console.WriteLine("not prime");
                }
                counter = 0;
                //add item to list.
                //li.Add(i);
            }

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            //var a = Math.Ceiling(Math.Sqrt(i));
        }

        public static bool BadPrimeCheck(int n)
        {
            //if it's divisible by any number other than itself it's not prime. otherwise return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
            //look on workbook
        }

        public static bool CheckIfPrimeGoodWaySqrt(int n)
        {
            if (n < 2)
                return false;

            int sqrt = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        #region RecursiveFactorial
        public static double Factorial(int number)
        {
            // Factorial using for loop non-recursive. Check for 0.
            if (number == 0)
                return 1;

            double factorial = 1;


            for (int i = number; i <= 1; i--) //5x4x3x2x1
            {
                factorial = factorial * i;
                //start = start*number(5/4/3/2/1/) = new start.
                // 1 = 1*5 = 5
                // 5 = 5*4 = 20
                // 20 = 20*3 = 60
                // 60 = 60*2 = 120
                // 120 = 120*1 = 120
            }

            return factorial;
        }

        public static double RecursiveFactorial(int number)
        {
            //check for 0.
            if (number == 0)
                return 1;

            return number * RecursiveFactorial(number - 1);
            //5*(4) = 20
            //20*(3) = 60
            //60*(2) = 120
            //120*(1) = 120

            // What it actually does, below. Reversed because it's on the memories stack calling back on itself.
            //1*1 = 1
            //1*2 = 2
            //2*3 = 6
            //6*4 = 20
            //20*5 = 120
        }
        #endregion

        #region AddNumberInRange+recursive
        public static int addNumberInRange(int num1, int num2)
        {
            if (num1 >= num2)
            {
                Console.WriteLine("The first number is greater or equal to the second number. Invalid range was given.");
                return num1;
            }

            int sum = 0;

            // loop from num1 upto num2 and add all values to sum, then return.
            for (int i = num1; i <= num1; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int addNumberInRangeRecursively(int num1, int num2)
        {
            int sum = num1;
            
            // make num = num1, check if its less than num2.
            if (num1 < num2)
            {
                // increment num1, and pass it into the method, oldsum+newsum repeated = answer. 
                num1++;
                return sum + (addNumberInRangeRecursively(num1, num2));
            }
            return sum;
        }
        #endregion  

        public static int SmallestPositiveNotInArray(int[] intArray)
        {
            // task is to return the smallest positive integer that is not in the given array, greater than 0.

            // create bool array. +1 to account for 0th index.
            var boolArray = new bool[intArray.Length + 1];

            // assign bool array indexes to be if true the number is in the int array.
            foreach (var number in intArray)
            {
                // no need to count any numbers higher than the lengh of the array.
                if (number > 0 && number < boolArray.Length)
                {
                    boolArray[number] = true;
                }

            }

            // for loop through the bool array finding the smallest int no included in the array. return result.
            for (int i = 1; i < boolArray.Length; i++)
            {
                // if the boolArray potision is false then return the number
                if (!boolArray[i])
                {
                    return i;
                }
            }
            // otherwise return the lenght of the bool array.
            return boolArray.Length;
        }


        #region test

        public static int SumOfAllNegativeNumbers(int[] intArray)
        {
            //Loop through the array, add all numbers less than 0. return output

            int sumOfNegative = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < 0)
                {
                    sumOfNegative += intArray[i];
                }
            }
            return sumOfNegative;
        }

        public static int CountNumberOf1stoN(int N)
        {
            //check how many times the digit '1' appears upto the number N.
            // assmuing we start at 0 and there are no negative numbers.
            // possible math funtion.

            int total = 0;

            int j = 0;
            // loop
            for (int i = 1; i <= N; i++)
            {
                j = i;
                while (j != 0)
                {
                    // use %10 to check if 1 exists.
                    if (j % 10 == 1)
                    {
                        total++;
                    }
                    // divide by 10 to check next digit    
                    j /= 10;

                }
            }
            return total;
        }

        public static int InterestingTimesINCOMPLETE(string S, string T)
        {
            // leading 0's are always shown
            // 13 : 31 : 33
            // intersting time = can make a time with only two distict digits.
            //00 : 00 : 00 and 11 : 11: 11 also count.
            // the ':' is always there and does not count.

            //task = count the interesting points in time in a period.

            // assumtions: S and T follow format of "HH:MM:SS".
            // S is a time before T on the same day.

            // my task:
            // I need to take in 2 string and check for all the "intersting" times between them.
            // if there are more than 2 distint digits then ignore.
            // don't take into account ':'.

            // This is a very difficult problem for me, Most likely wont be able to complete,
            // but I will add comments to what i would do and attempt to start.

            //convert the string into DateTime
            var firstTime = DateTime.Parse("01:02:01");
            var secondTime = DateTime.Parse("11:02:01");

            TimeSpan diff = secondTime.Subtract(firstTime);

            int count = 0;
            while (firstTime<secondTime)
            {
                // if statement to check for interesting times
                // checking if the string without ':' contains less than two distinct digits.
                if (true)
                {
                    count++;
                }
                // add an extra second at the end until secondTime is reached.
                firstTime.AddSeconds(1);
            }

            return 1;
        }

        #endregion
        public int interestingTimeSecondIMCOMPLETE(string S, string T)
        {
            // leading 0's are always shown
            // 13 : 31 : 33
            // intersting time = can make a time with only two distict digits.
            //00 : 00 : 00 and 11 : 11: 11 also count.
            // the ':' is always there and does not count.

            //task = count the interesting points in time in a period.

            // assumtions: S and T follow format of "HH:MM:SS".
            // S is a time before T on the same day.

            // my task:
            // I need to take in 2 string and check for all the "intersting" times between them.
            // if there are more than 2 distint digits then ignore.
            // don't take into account ':'.

            // This is a very difficult problem for me, Most likely wont be able to complete,
            // but I will add comments to what i would do and attempt to start.


            //testing# Ran out of time, wasn't able to find a working solution#
            var firstTime = DateTime.Parse(S);
            var secondTime = DateTime.Parse(T);

            // the difference in time. not relevant for now.
            TimeSpan timeDifference = firstTime.Subtract(secondTime);

            // loop through every second in between the times.
            // that doesn't contain more than two distinct digts?

            // add one to a count variable to track interseting times.
            int count = 0;
            while (firstTime < secondTime)
            {
                // if statement to check for interesting times
                // checking if the string without ':' contains less than two distinct digits.
                if (true)
                {
                    count++;
                }
                // add an extra second at the end until secondTime is reached.
                firstTime.AddSeconds(1);
            }


            //for compiler if incomplete.
            return 1;

        }
    }
}
