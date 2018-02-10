using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public static class BubbleSort
    {

        public static int[] Sort(initArr arr)
        {
            int[] bubbleArr = arr.Arr();
            int size = bubbleArr.Length;
            for (int i = 0; i < bubbleArr.Length; i++)
            {
                for (int j = 0; j < size-1; j++)
                {
                    if (bubbleArr[j] > bubbleArr[j + 1])
                    {
                        bubbleArr[j + 1] = bubbleArr[j + 1] + bubbleArr[j];
                        bubbleArr[j] = bubbleArr[j + 1] - bubbleArr[j];
                        bubbleArr[j + 1] = bubbleArr[j + 1] - bubbleArr[j];
                    }
                }
                size--;
            }
            return bubbleArr;
        }
    }
}
