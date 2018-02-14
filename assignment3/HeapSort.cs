using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace assignment3
{
    class HeapSort
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
        public static int[] Sort(InitArr arr)
        {
            int[] array = new int[arr.Arr().Length];
            Array.Copy(arr.Arr(), array, arr.Arr().Length);
            var watch = Stopwatch.StartNew();

            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heap(array, array.Length, i);
            }

            int temp;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heap(array, i, 0);
            }

            watch.Stop();
            elapsedTime = watch.ElapsedTicks * (1000000.0 / Stopwatch.Frequency);

            return array;
        }

        private static void Heap(int[] array, int n, int i)
        {
            int parent = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild < n && array[leftChild] > array[parent])
                parent = leftChild;

            if (rightChild < n && array[rightChild] > array[parent])
                parent = rightChild;

            if (parent != i)
            {
                int temp = array[i];
                array[i] = array[parent];
                array[parent] = temp;

                Heap(array, n, parent);
            }
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
