using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class InterviewQuestions
    {
        public static void fizzBuzzBasic()
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

        public static void fizzBuzzString()
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

        public static bool palindrome(string str)
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

        public static void revString(string str)
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

        public static void rString(string str)
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

        public static void sumOfPrime(int min, int max)
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

        public static bool isPrime(int n)
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

    }
}
