using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public struct initArr
    {
        int[] inputArr;
        public initArr(int size)
        {
            this.inputArr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                this.inputArr[i] = random.Next(1000);
                Console.WriteLine(inputArr[i]);
            }

        }
    }
}