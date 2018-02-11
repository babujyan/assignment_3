using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public static class BubbleSort
    {

        public static void Sort(InitArr arr)
        {

            int[] array = new int[arr.Arr().Length];
            Array.Copy(arr.Arr(), array, arr.Arr().Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int size = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < size-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j + 1] = array[j + 1] + array[j];
                        array[j] = array[j + 1] - array[j];
                        array[j + 1] = array[j + 1] - array[j];
                    }
                }
                size--;
            }
            Console.WriteLine("sorted");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
