using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class MergeSort
    {
        public static int[] Sort(InitArr arr)
        {
            int[] array = new int[arr.Arr().Length];
            Array.Copy(arr.Arr(), array, arr.Arr().Length);


            return array;
        }
    }
}
