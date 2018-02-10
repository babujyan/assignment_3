using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class QuickSort
    {
        public static int[] Sort(InitArr arr)
        {
            int[] array = arr.Arr();
            array = Partition(array, 0, array.Length - 1);
            int k = 0;
            while (k < array.Length)
            {
                Console.WriteLine(array[k]);
                k++;
            }
            return array;
        }
        static int[] Partition(int[] array, int low, int high)
        {
            int pivot = high;
            int j = high - 1;
            int i = low;
            while (j>=i)
            {

                while (array[pivot] <= array[j] && j >= i)
                {
                    array[pivot] = array[pivot] + array[j];
                    array[j] = array[pivot] - array[j];
                    array[pivot] = array[pivot] - array[j];
                    pivot = j;
                    j--;
                }
                if (array[pivot] <= array[i] && i < j)
                {
                    int tamp = array[pivot];
                    array[pivot] = array[i];
                    array[i] = array[j];
                    array[j] = tamp;
                    pivot = j;
                    i++;
                    j--;
                }
            }
            if(low < pivot)
                Partition(array, low, pivot - 1);
            if(high > pivot)
                Partition(array, pivot + 1, high);
     
            return array;
        }

    }
}
