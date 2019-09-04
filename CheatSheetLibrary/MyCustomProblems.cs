using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class MyCustomProblems
    {
        // This class contains problems that I thought up on the spot.

        // #1 Given a string, print/return the most common character, case insensitive.
        // if multiple characters appear, show the first sorted by alphabetical order. (Assumes no numbers are used.)

        public static string MostCommonCharacter(string input)
        {
            // remove spaces and make string array.
            var str = input.ToLower().Replace(" ", string.Empty);

            //  create dictionary to store count of key value pairs. 
            var dict = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            foreach (var k in dict.Keys)
            {
                Console.WriteLine("The letter '{0}' appears {1} time(s).", k, dict[k]);
            }

            // find the most occuring character by alphabetical order and print/return.
            foreach (var item in dict.OrderByDescending(key => key.Value).Take(1))
            {
                Console.WriteLine("The most frequent letter is '{0}' appearing {1} time(s)",item.Key,item.Value);
                return item.Key.ToString();
            }
            return "No valid value";
        }


    }
}
