using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class CodeWars
    {

        #region 6 kyu
        // 6 KYU~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public static string Order(string words)
        {
            // Your task is to sort a given string. Each word in the string will contain a single number.This number is the position the word should have in the result.
            // Note: Numbers can be from 1 to 9.So 1 will be the first word(not 0).
            //If the input string is empty, return an empty string.The words in the input String will only contain valid consecutive numbers.

            // "is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"

            if (string.IsNullOrEmpty(words)) return words;

            // split string. find and order by digits. join back to string and return.
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));

        }

        public static int find_it(int[] seq)
        {
            // Given an array, find the int that appears an odd number of times.
            // There will always be only one integer that appears an odd number of times.

            // groups values
            var val = seq.GroupBy(p => p);
            foreach (var v in val)
            {
                // if the count of values is odd, return;
                if (v.Count() % 2 == 1)
                {
                    return v.Key;
                }
            }
            return -1;

            // return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }

        #endregion

        #region 7 kyu
        // 7 KYU~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        public static int[] minMax(int[] lst)
        {
            // Write a function that returns both the minimum and maximum number of the given list/array.
            // MinMax.minMax(new int[]{1,2,3,4,5}) == {1,5}
            // MinMax.minMax(new int[]{1}) == {1, 1}

            return new int[] { lst.Min(), lst.Max() };
        }

        public static bool IsAnagram(string test, string original)
        {
            // Note: anagrams are case insensitive
            // Complete the function to return true if the two arguments given are anagrams of theeach other; return false otherwise.
            // "foefet" is an anagram of "toffee"
            // "Buckethead" is an anagram of "DeathCubeK"

            // to chararrym, sort. compare.

            var t = test.ToLower().ToCharArray();
            var o = original.ToLower().ToCharArray();

            Array.Sort(t);
            Array.Sort(o);

            var tstring = new string(t);
            var ostring = new string(o);

            return ostring == tstring;

        }

        public static int FindShort(string s)
        {
            //Simple, given a string of words, return the length of the shortest word(s).
            //String will never be empty and you do not need to account for different data types.
            //return s.Split(' ').Min(x => x.Length);
            return s.Split().ToList().OrderBy(p => p.Length).First().Length;

        }

        public static string HighAndLow(string numbers)
        {
            // In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
            // Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"

            // Best code =
            //var parsed = numbers.Split().Select(int.Parse);
            //return parsed.Max() + " " + parsed.Min();
            List<int> sList = numbers.Split(' ').Select(Int32.Parse).ToList();
            sList.Sort();
            return $"{sList.Max()} {sList.Min()}";
        }

        public static int GetVowelCount(string str)
        {
            // Return the number (count) of vowels in the given string.
            // We will consider a, e, i, o, and u as vowels for this Kata.     
            // The input string will only consist of lower case letters and / or spaces.
            // Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
            //=================
            // best soolution = return str.Count(i => "aeiou".Contains(i));
            int vowelCount = 0;
            foreach (var item in str)
            {
                if ((item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u'))
                {
                    vowelCount++;
                }

            }
            return vowelCount;
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
            //ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}

            return listOfItems.OfType<int>().Cast<int>();

            //List<int> ints = listOfItems.OfType<int>().ToList();
            //return ints;

        }

        public static string GetMiddle(string s)
        {
            //You are going to be given a word. Your job is to return the middle character of the word.
            //If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
            //Kata.getMiddle("test") should return "es"
            //Kata.getMiddle("testing") should return "t"
            //Kata.getMiddle("A") should return "A"
            return s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2, 1);


            //{
            //    return s.Substring(s.Length / 2 , 2);                
            //}

            //if (s.Length % 2 != 0)
            //{
            //    return s.Substring(s.Length / 2, 1);
            //}                     
        }

        public static String Accum(string s)
        {
            //take a string and return as shown in example.!!
            //Accumul.Accum("abcd"); = // "A-Bb-Ccc-Dddd"
            //user solutions:
            //return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));

            string result = "";
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        result = result + char.ToUpper(charArray[i]);
                    }
                    else
                    {
                        result = result + char.ToLower(charArray[i]);
                    }
                }
                if (i != charArray.Length - 1)
                {
                    result = result + '-';
                }

            }
            return result;

        }

        public static int Solution(int value)
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            // Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
            // Note: If the number is a multiple of both 3 and 5, only count it once.

            //value = 10
            // 3+5+6+9 = 23
            //return 23

            List<int> output = new List<int>();
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    output.Add(i);
                }
            }
            return output.Sum();
            // return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum(); //change input "value" to "n"
        }

        #endregion

        #region 8 kyu
        //8 KYU~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public static int MakeNegative(int number)
        {
            //In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
            //return number > 0 ? number*-1:number;
            return -Math.Abs(number);
        }

        public static string EvenOrOdd(int number)
        {
            //Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
            return (number % 2 == 0) ? "Even" : "Odd";
            //var dbl = Convert.ToDouble(number);

            /*if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
            */
        }

        public static string Remove_Char(string s)
        {
            //It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string.
            //You're given one parameter, the original string.You don't have to worry with strings with less than two characters.


            var a = s.Substring(1, s.Length - 2);



            return a;

        }


        public static bool DoesItEndWith(string str, string ending)
        {
            // Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
            //solution('abc', 'bc') // returns true
            // solution('abc', 'd') // returns false

            //if (str.Substring(str.Length - ending.Length) == ending)
            //{
            //    return true;
            //}
            //else { return false; }

            if (ending.Length > str.Length)
            {
                return false;
            }
            return str.Substring(str.Length - ending.Length) == ending;
            //return str.EndsWith(ending);

        }

        public static string NoSpace(string input)
        {
            //remove all spaces from a string.
            return input.Replace(" ", string.Empty);
        }



        public static string boolToWord(bool word)
        {
            //Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
            return word ? "Yes" : "No";
        }

        public static int CountSheeps(bool[] sheeps)
        {
            //Consider an array of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present/ false absent).
            //var a = sheeps.Where(c => c ).Count();
            return sheeps.Count(c => c);
        }

        public static int FindSmallestInt(int[] args)
        {
            //Given an array of integers your solution should find the smallest integer.
            return args.Min();
        }


        public static string UpdateLight(string current)
        {
            //You're writing code to control your town's traffic lights.You need a function to handle each change from green, to yellow, to red, and then to green again.
            //Complete the function that takes a string as an argument representing the current state of the light and returns a string representing the state the light should change to.
            switch (current)
            {
                case "green": return "yellow";
                case "yellow": return "red";
                case "red": return "green";
                default:
                    break;
            }
            return "nothing";

        }

        public static string repeatStr(int n, string s)
        {
            //Write a function called repeatStr which repeats the given
            //string string exactly n times.
            /*
            var st = s;
            for (int i = 1; i < n; i++)
            {
                
                st += s;
            }
            return st;
            */
            return string.Concat(Enumerable.Repeat(s, n));

        }

        public static int Opposite(int number)
        {
            //Very simple, given a number, find its opposite. eg: 1:-1, -14:14.
            //var a = number > 0 ? number - number - number : number*-1;
            //return number * -1;
            return -number;

        }

        public static int PositiveSum(int[] arr)
        {
            //You get an array of numbers, return the sum of all of the positives ones.
            //example array should = 13; var x = new int[] { 1, -2, 3, 4, 5 };

            var positiveSum = arr.Where(x => x > 0).Sum();
            //var sum = arr.Sum();
            return positiveSum;
        }


        #endregion
    }
}
