using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetLibrary
{
    public class Algorithms
    {
        string path = "";

        #region generate read and write array
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

        //static void WriteToFile(string path, int[] randArray)
        //{
        //    try
        //    {
        //        using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "WriteLines1m.txt")))
        //        {
        //            foreach (int item in randArray)
        //                outputFile.WriteLine(item);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //static int[] readFromFile(string path, int arraySize)
        //{
        //    int[] array = new int[arraySize];

        //    try
        //    {
        //        using (StreamReader DataFile = new StreamReader(@"C:\Users\asus\Desktop\Programming\algorithms\Algorithms\Algorithms\WriteLines500k.txt"))
        //        {
        //            Console.WriteLine(path);
        //            //parse the string from each line and add it to the array.
        //            for (int i = 0; i < arraySize; i++)
        //            {
        //                string sNum = DataFile.ReadLine();
        //                array[i] = int.Parse(sNum);
        //            }

        //            return array;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        #endregion

        #region bubblesort
        static int[] BubbleSort(int[] randArray)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < randArray.Length - 1; i++)
                {
                    if (randArray[i] > randArray[i + 1])
                    {
                        swap(randArray, i, i + 1);
                        isSorted = false;
                    }
                }
            }

            return randArray;
        }
        
        public static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        #endregion

    }
}
