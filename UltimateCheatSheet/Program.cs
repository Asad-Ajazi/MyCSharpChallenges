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
            //int[] intArr = new int[] { 8, 7, 4, 5, 6, 3, 2, 1, 10, 88, 62, 45, 12, 36, 24, 78 };
            int[] intArr = new int[] { 8, 7, 4, 5, 6, 3, 2 };
            int[] sortedArr = new int[] { 1, 2, 4, 6, 8 };

            var x = LeetCodeProblems.RemoveVowelsFromString("ahahahkloaeioujfjfshi");

            Console.WriteLine(x);
            

            
            Console.ReadLine();
        }
    }
}
