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
            int[] nums = { 2, 7, 11, 15 };
            var x = LeetCodeProblems.TwoSum(nums, 24);
            Console.WriteLine(x);
            
            Console.ReadLine();
        }
    }
}
