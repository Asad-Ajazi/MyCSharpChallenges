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

        // Sample array
        //int[] intArr = new int[] { 8, 7, 4, 5, 6, 3, 2, 1, 0, 10, 88, 62, 45, 12, 36, 24, 78, 54 };
        //int[] intArr = new int[] { 8, 7, 4, 5, 6, 3, 2, 1 };

        #region bubblesort
        // Start from the beginning, swap pairs if frst is greater than second.
        public static int[] BubbleSort(int[] randArray)
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

        #region Merge Sort NOTWORKING
        //CURRENTLY NOT WORKING AS EXPECTED.
        // Divide array in half, sort halves and merge back together.
        public static void MergeSort(int[] initialArray)
        {
            // create helper array(same size).
            int[] helperArray = new int[initialArray.Length];
            // call mergesort2(initial, helperA, start index, end index.)
            MergeSort(initialArray, helperArray, 0, initialArray.Length - 1);
        }

        static void MergeSort(int[] initialArray, int[] helperArray, int low, int high)
        {
            if (low < high)
            {
                // get middle
                int middle = low + (high - low) / 2;
                // sort left half(inital, helperA, leftstart, leftend = middle.)
                MergeSort(initialArray, helperArray, low, middle);
                // sort right half(inital, helperA, rightstart = mid+1, rightend = high.)
                MergeSort(initialArray, helperArray, middle + 1, high);

                // merge the halves(initial, helperA, low, mid, high)
                MergeHalves(initialArray, helperArray, low, middle, high);

            }
        }

        static void MergeHalves(int[] initialArray, int[] helperArray, int low, int middle, int high)
        {
            // copy both halves into helper array.
            for (int i = low; i <= high; i++)
            {
                helperArray[i] = initialArray[i];
            }

            // more variables
            int helperLeft = low; //start left index
            int helperRight = middle + 1; // start right index
            int current = low; // current index.

            // iterate helper array, compare left and right
            // copy the smaller element from the two halves into the initial array.
            while (helperLeft <= middle && helperRight <= high)
            {
                if (helperArray[helperLeft] <= helperArray[helperRight])
                {
                    initialArray[current] = helperArray[helperLeft];
                    helperLeft++;
                }
                else
                {
                    // if right element is smaller than the left element.
                    initialArray[current] = helperArray[helperRight];
                    helperRight++;
                }
                //increment current index for inital array each time.
                current++;
            }

            // copy the rest of the left side of the helper array into the initial array.
            int remaining = middle - helperLeft;
            for (int i = 0; i <= remaining; i++)
            {
                initialArray[current+1] = helperArray[helperLeft+1];
            }
        }



        #endregion


    }
}
