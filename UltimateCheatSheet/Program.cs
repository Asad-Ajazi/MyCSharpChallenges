using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheatSheetLibrary;

//this is my ultimate cheet sheet where i put all the things.
namespace UltimateCheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {

            //InterviewQuestions.sumOfPrime(1, 50);
            //Console.WriteLine(WorkingWithPrimes.RemoveEachDigitNthPrimeNumber(197));

            int[] arr = {-88, -99, -66, 0, 3, 65, 5, 4, 3, 2, 1, 8, 9, 6, 4 };
            int x = InterviewQuestions.SmallestPositiveNotInArray(arr);
            Console.WriteLine(x);


            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
