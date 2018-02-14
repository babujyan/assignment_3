using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace assignment3
{
    /// <summary>
    /// Class for Merge Sort algorithm
    /// </summary>
    static class MergeSort
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
        /// Sort function via Merge sort.
        /// </summary>
        /// <param name="arr"> Array with type InitAr. </param>
        public static int[] Sort(InitArr arr)
        {
            int[] array = new int[arr.Arr().Length];
            Array.Copy(arr.Arr(), array, arr.Arr().Length);
            var watch = Stopwatch.StartNew();
            mergeSort(array, 0, array.Length - 1);

            watch.Stop();
            elapsedTime = watch.ElapsedTicks * (1000000.0 / Stopwatch.Frequency);

            return array;
        }

        private static void mergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                mergeSort(array, low, middle);
                mergeSort(array, middle + 1, high);
                merge(array, low, middle, high);
            }
        }

        private static void merge(int[] array, int low, int middle, int high)
        {
            int i = low;
            int k = 0;
            int j = middle + 1;
            int[] temp = new int[high - low + 1];
            memory += 32 * temp.Length;
            Array.Copy(array, low, temp, 0, temp.Length);

            while (i <= middle && j <= high)
            {
                if (array[i] <= array[j])
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
            }

            if (i <= middle)
            {
                for (j = i; j <= middle; j++)
                {
                    temp[k++] = array[j];
                }
            }
            else
            {
                for (i = j; i <= high; i++)
                {
                    temp[k++] = array[i];
                }
            }
            Array.Copy(temp, 0, array, low, temp.Length);
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