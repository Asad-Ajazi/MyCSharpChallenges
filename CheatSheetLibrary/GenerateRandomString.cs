using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class GenerateRandomString
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static int[] GenerateRandomArray()
        {
            // create an array
            int size = 1000000;
            int[] array = new int[size];
            Random r = new Random();

            // populate it with random numbers.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, size);
            }

            return array;
        }
    }
}
