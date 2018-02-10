using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public static class InsertionSort
    {
        public static int[] Sort(InitArr arr)
        {
            int[] array = arr.Arr();
            int size = array.Length;
            for(int i = 1; i < array.Length; ++i)
            {
                int j = i;
                while(j > 0 && array[j-1] > array[j])
                {
                    array[j] = array[j] + array[j-1];
                    array[j-1] = array[j] - array[j-1];
                    array[j] = array[j] - array[j-1];
                    j--;
                }
            }

            return array;
        }
    }
}
