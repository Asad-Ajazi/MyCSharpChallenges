using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class WorkingWithPrimes
    {
        // r
        public static int RemoveEachDigitNthPrimeNumber(int n)
        {
            int count, currentNumber, tempNumber;
            bool prime;
            for (count = 0, currentNumber = 2; count < n; currentNumber++)
            {
                if (ZeroCheck(currentNumber))
                {
                    continue;
                }

                if (PrimeCheck(currentNumber))
                {
                    prime = true;
                    tempNumber = currentNumber;

                    while (prime == true)
                    {
                        if (tempNumber.ToString().Length < 1)
                        {
                            prime = false;
                            continue;
                        }

                        if (tempNumber.ToString().Length == 1 && PrimeCheck(tempNumber))
                        {
                            count++;
                            prime = false;
                            continue;
                        }
                        tempNumber = removeFirst(tempNumber);
                        prime = PrimeCheck(tempNumber);
                    }
                }
            }
            return currentNumber - 1;
        }

        //backup code with initial logic. use this if you get lost.
        static int startfromhereiffailed(int n)
        {
            int count, currentNumber;
            for (count = 0, currentNumber = 2; count < n; currentNumber++)
            {
                //only if the number is robust prime will count++.
                if (PrimeCheck(currentNumber))
                {

                    ++count;
                }

            }
            return currentNumber - 1;
        }


        // remove the first digit of the number.
        static int removeFirst(int input)
        {
            string newNumber = input.ToString().Substring(1);
            return Convert.ToInt32(newNumber);
        }

        static int getFinalint(int input)
        {
            string number = input.ToString();
            number = number.Substring(number.Length - 1);
            return Convert.ToInt32(number);
        }

        //check if contains 0.
        static bool ZeroCheck(int n)
        {
            return n.ToString().Contains("0");
        }

        //checks if the number is prime;
        static bool PrimeCheck(int n)
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

        //--------------------------------------------------------------------------------------

        public static List<int> nthRobustPrime(int n)
        {
            List<int> x = new List<int>();
            int count, currentNumber;
            for (count = 0, currentNumber = 2; count < n; ++currentNumber)
            {
                if (isPrime(currentNumber))
                {
                    if (!ZeroCheck(currentNumber))
                    {
                        if (currentNumber.ToString().Length > 2)
                        {
                            var next = removeFirst(currentNumber);
                        }
                    }
                    ++count;
                    x.Add(currentNumber);
                }
            }
            // primeCandidate was incremented by one after reaching n, so -1.
            //return currentNumber - 1;
            return x;
        }

        //static int robustlyPrimeNumber(int input)
        //{
        //    List<int> intList = new List<int>();
        //    int userNumber = Convert.ToInt32(input);

        //    //in a for loop. j will count the number of rpn so far.
        //    //if 
        //    for (int i = 2, j = 0; i < userNumber; i++)
        //    {
        //        //if (isPrime(i))
        //        //{
        //        //    if ((int)Math.Floor(Math.Log10(i)) + 1 > 1)
        //        //    {
        //        //        isRobustlyPrime = containtsZero(i.ToString());//return false if it has a 0.
        //        //    }
        //        //}

        //        if (!isPrime(i) || containtsZero(i.ToString()))
        //            continue;

        //        //if (isPrime(i))
        //        //{
        //        //    if (i.ToString().Length > 1)
        //        //    {
        //        //        removeFirst(i);
        //        //    }
        //        //    j++;
        //        //}

        //        var temp = i;
        //        while (i.ToString().Length > 1 && isPrime(i))
        //        {
        //            i = removeFirst(i);
        //        }

        //        if (isPrime(i))
        //        {
        //            intList.Add(temp);
        //            j++;
        //            Console.WriteLine(intList[j]);
        //        }
        //        Console.WriteLine("????");
        //        return 1;
        //    }


        //}

        static bool containtsZero(string userValue)
        {
            if (userValue.Contains('0'))
            {
                return true;
            }
            return false;
        }



        static bool isPrime(int input)
        {
            //if it's divisible by any number other than itself it's not prime. otherwise return true;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
            //look on workbook
        }


        #region other stuff
        private static int getNextDigit(int n)
        {
            int sum = 0;
            while (n != 0)
            {

                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private static int RemovedDigit(int n)
        {
            var next = n.ToString().Substring(1);
            if (next.Length > 1)
            {
                return Convert.ToInt32(next);

            }
            return n;
        }


        #endregion

        #region cracking the coding interview;
        //Sieve of Eratosthenes

        static bool[] ListPrimes(int max)
        {
            //bool[] flags = new bool[max + 1];
            bool[] flags = Enumerable.Repeat(true, max - 1).ToArray();
            int count = 0;

            int prime = 2;

            while (prime <= Math.Sqrt(max))
            {
                crossOff(flags, prime);

                prime = getNextPrime(flags, prime);
            }
            return flags;
        }

        static void crossOff(bool[] flags, int prime)
        {
            for (int i = prime * prime; i < flags.Length; i += prime)
            {
                flags[i] = false;
            }
        }

        static int getNextPrime(bool[] flags, int prime)
        {
            int next = prime + 1;
            while (next < flags.Length && !flags[next])
            {
                next++;
            }
            return next;
        }

        #endregion

    }
}
