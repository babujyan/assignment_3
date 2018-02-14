using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace assignment3
{
    /// <summary>
    /// This is a Quick sort class
    /// </summary>
    class QuickSort
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
        /// Sort method for Quick sort.
        /// </summary>
        /// <param name="arr"> Array with type InitAr. </param>
        /// <returns>Returns sorted array</returns>
        public static int[] Sort(InitArr arr)
        {
            
            int[] array = new int[arr.Arr().Length];
            Array.Copy(arr.Arr(), array, arr.Arr().Length);

            var watch = Stopwatch.StartNew();

            Quick(array, 0, array.Length - 1);

            watch.Stop();
            elapsedTime = watch.ElapsedTicks * (1000000.0 / Stopwatch.Frequency);

            return array;
        }

        /// <summary>
        /// Sorts array via Quick sort.
        /// </summary>
        /// <param name="array">  Array whic is going to be sorted. </param>
        /// <param name="left"> Index wher to start sorting. </param>
        /// <param name="right"> Index wher to start sorting. </param>
        private static void Quick(int[] array, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(array, left, right);
                Quick(array, left, p - 1);
                Quick(array, p + 1, right);
            }
        }

        /// <summary>
        /// Partition for Quick sort.
        /// </summary>
        /// <param name="array"> Array whic is going to be sorted. </param>
        /// <param name="low"> Lowest index for sorting. </param>
        /// <param name="high"> Highest index for sorting. </param>
        /// <returns>Index</returns>
        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int index = low;
            int temp;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivot)
                {
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                    index++;
                }
            }

            temp = array[high];
            array[high] = array[index];
            array[index] = temp;

            return index;
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
