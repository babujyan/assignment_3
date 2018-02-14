using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace assignment3
{
    /// <summary>
    /// Init new random array.
    /// </summary>
    public struct InitArr
    {
        int[] inputArr;
        /// <summary>
        /// Ranom array
        /// </summary>
        /// <param name="size">Size of the array. </param>
        public InitArr(int size)
        {
            this.inputArr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                this.inputArr[i] = random.Next();
            }

        }

        /// <summary>
        /// Givs an array.
        /// </summary>
        /// <returns></returns>
        public int[] Arr()
        {
            return this.inputArr;
        }
    }
}