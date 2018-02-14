using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace assignment3
{
    /// <summary>
    /// 
    /// </summary>
    class NewInput
    {
        
        List<int> sortingNumber = new List<int>();
        int[] sortingNumberArr;
        InitArr arr;
        string userInput;

        ///<sumary>
        /// 
        ///</sumary>
        public NewInput()
        {

            Console.WriteLine("Please enter the size of an array");
            this.userInput = Console.ReadLine();
            arr = new InitArr(Int32.Parse(userInput));
            Console.WriteLine("Select which algorithm you want to perform: \n " +
                    "1. Insertion sort " +
                    "\n 2. Bubble sort " +
                    "\n 3. Quick sort " +
                    "\n 4. Heap sort " +
                    "\n 5. Merge sort" +
                    "\n 6. all");
            do
            {
                this.userInput = Console.ReadLine();

                if (Regex.IsMatch(userInput, "^[1-6]$"))
                {
                    if (Int32.TryParse(this.userInput, out int k))
                    {
                        if(Int32.Parse(this.userInput) == 6)
                        {
                            for(int i = 1; i < 6;i++)
                            {
                                this.sortingNumber.Add(i);
                            }
                        }
                        else
                            this.sortingNumber.Add(Int32.Parse(this.userInput));

                        sortingNumberArr = this.sortingNumber.ToArray();
                    }
                    else Console.WriteLine("error");
                    break;
                }

                else if (Regex.IsMatch(this.userInput, "^[1-5]-[1-5]$"))
                {
                    Regex regex = new Regex("[-]");
                    string[] substrings = regex.Split(this.userInput);
                    foreach (string match in substrings)
                    {
                        if (Int32.TryParse(match, out int k))
                        {
                            //WriteLine(Int32.Parse(match));
                            this.sortingNumber.Add(Int32.Parse(match));
                        }
                        else Console.WriteLine("error");
                    }
                   
                    if(sortingNumber[0]>=sortingNumber[1])
                    {
                        sortingNumber[1] = sortingNumber[1] + sortingNumber[0];
                        sortingNumber[0] = sortingNumber[1] - sortingNumber[0];
                        sortingNumber[1] = sortingNumber[1] - sortingNumber[0];
                    }
                    int someValue = sortingNumber[0]+1;
                    for (int i = 2; i<=sortingNumber[1]-sortingNumber[0] ; i++)
                    {

                        this.sortingNumber.Add(someValue);
                        someValue++;

                    }
                    sortingNumberArr = this.sortingNumber.ToArray();
                    break;
                }

                else if (Regex.IsMatch(this.userInput, "^(([1-5][,]){1,100}?)[1-5]$"))
                {
                    Regex regex = new Regex("[,]");
                    string[] substrings = regex.Split(userInput);
                    foreach (string match in substrings)
                    {
                        if (Int32.TryParse(match, out int k))
                        {
                            this.sortingNumber.Add(Int32.Parse(match));
                        }
                        else Console.WriteLine("error");
                    }
                    sortingNumberArr = this.sortingNumber.ToArray();
                    break;
                }

                else
                {
                    Console.WriteLine("wrong input");
                }
            }
            while (true);
        }

        public void Sort()
        {
            double[] Time = new double[6];



            for (int i=0; i< sortingNumberArr.Length; i++)
            {

                int caseSwitch = sortingNumber[i];
                switch (caseSwitch)
                {
                    case 1://Insertion sort
                        {
                            InsertionSort.Sort(arr);
                            Time[1] = InsertionSort.GetTime();
                            break;
                        }

                    case 2: //Bubble sort
                        {
                            BubbleSort.Sort(arr);
                            Time[2] = BubbleSort.GetTime();

                            break;
                        }
                    case 3: //Quick sort
                        {
                            QuickSort.Sort(arr);
                            Time[3] = QuickSort.GetTime();
                            break;
                        }

                    case 4: //Heap sort
                        {
                            HeapSort.Sort(arr);
                            Time[4] = HeapSort.GetTime();
                            break;
                        }

                    case 5: //Merge sort
                        {
                            MergeSort.Sort(arr);
                            Time[5] = MergeSort.GetTime();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }

            double min = Time[1];
            for(int i = 1; i <=5; i++)
            {
                if(min > Time[i])
                {
                    min = Time[i];
                }
            }

            for (int i = 0; i < sortingNumberArr.Length; i++)
            {

                int caseSwitch = sortingNumber[i];
                switch (caseSwitch)
                {
                    case 1://Insertion sort
                        if (Time[1]==min)
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Insertion sort");
                            Console.WriteLine("Running time: " + Time[1]);

                            Console.WriteLine("Memory usage: " + BubbleSort.GetMemory());
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Insertion sort");
                            Console.WriteLine("Running time: " + Time[1]);

                            Console.WriteLine("Memory usage: " + BubbleSort.GetMemory());
                            break;
                        }

                    case 2: //Bubble sort
                        if (Time[2] == min)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bubble sort");
                            Console.WriteLine("Running time: " + Time[2]);
                            Console.WriteLine("Memory usage: " + BubbleSort.GetMemory());
                            Console.ResetColor();
                            break;
                        }
                        else
                        {

                            Console.WriteLine("Bubble sort");
                            Console.WriteLine("Running time: " + Time[2]);
                            Console.WriteLine("Memory usage: " + BubbleSort.GetMemory());


                            break;
                        }
                    case 3: //Quick sort
                        if (Time[3] == min)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Quick sort");
                            Console.WriteLine("Running time: " + Time[3]);

                            Console.WriteLine("Memory usage: " + QuickSort.GetMemory());
                            Console.ResetColor();
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine("Quick sort");
                            Console.WriteLine("Running time: " + Time[3]);

                            Console.WriteLine("Memory usage: " + QuickSort.GetMemory());

                            break;
                        }

                    case 4: //Heap sort
                        if (Time[4] == min)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Heap sort");
                            Console.WriteLine("Running time: " + Time[4]);

                            Console.WriteLine("Memory usage: " + HeapSort.GetMemory());

                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Heap sort");
                            Console.WriteLine("Running time: " + Time[4]);


                            Console.WriteLine("Memory usage: " + HeapSort.GetMemory());
                            break;
                        }

                    case 5: //Merge sort
                        if (Time[5] == min)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Merge sort");
                            Console.WriteLine("Running time: " + Time[5]);

                            Console.WriteLine("Memory usage: " + MergeSort.GetMemory());

                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Merge sort");
                            Console.WriteLine("Running time: " + Time[5]);


                            Console.WriteLine("Memory usage: " + MergeSort.GetMemory());

                            break;
                        }

                    default:
                        break;
                }
            } 
        }
    }
}
