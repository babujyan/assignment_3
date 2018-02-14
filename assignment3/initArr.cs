using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace assignment3
{
    public struct InitArr
    {
        int[] inputArr;
        public InitArr(int size)
        {
            this.inputArr = new int[size];
            Random random = new Random();
        }

        public int[] Arr()
        {
            return this.inputArr;
        }
    }
}