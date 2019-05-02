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

            var my = DateTime.Parse("01:02:01");
            var time2 = DateTime.Parse("11:02:01");

            TimeSpan diff = time2.Subtract(my);
            int[] arr = {3 };

            var x =InterviewQuestions.SumOfAllNegativeNumbers(arr);
            Console.WriteLine(x);
            
            Console.ReadLine();
        }
    }
}
