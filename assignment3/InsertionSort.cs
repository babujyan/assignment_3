using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace assignment3
{
    public static class InsertionSort
    {
        /// <summary>
        /// Elapsed Time 
        /// </summary>
        private static double elapsedTime;

        /// <summary>
        /// Used Memory
        /// </summary>
        private static int memory = 0;

        /// <summary>
        /// Sort function, uses the heap sort algoritm
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <returns>Returns sorted array</returns>
        public static void Sort(InitArr arr)
        {
            int[] array = new int[arr.Arr().Length];
            Array.Copy(arr.Arr(), array, arr.Arr().Length);

            var watch = Stopwatch.StartNew();
            
            int size = array.Length;
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    array[j] = array[j] + array[j - 1];
                    array[j - 1] = array[j] - array[j - 1];
                    array[j] = array[j] - array[j - 1];
                    j--;
                }
            }
            watch.Stop();
            elapsedTime = watch.ElapsedTicks * (1000000.0 / Stopwatch.Frequency);
        }

        /// <summary>
        /// Gives elapsed time in miliseconds.
        /// </summary>
        /// <returns></returns>
        public static double GetTime()
        {
            return elapsedTime;
        }

        /// <summary>
        /// Gives used emory in bytes.
        /// </summary>
        /// <returns></returns>
        public static int GetMemory()
        {
            return memory;
        }
    }
}
