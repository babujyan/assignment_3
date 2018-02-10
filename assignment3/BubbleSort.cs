using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public static class BubbleSort
    {

        public static int[] Sort(InitArr arr)
        {
            int[] array = arr.Arr();
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
            return array;
        }
    }
}
