using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assignment3
{
    class NewInput
    {
        
        List<int> sortingNumber = new List<int>();
        int[] sortingNumberArr;
        initArr arr;
        string userInput;
        bool all = false;

        public NewInput()
        {

            Console.WriteLine("Please enter the size of an array");
            this.userInput = Console.ReadLine();
            arr = new initArr(Int32.Parse(userInput));
            Console.WriteLine("Please enter the sorting algoritm \n " +
                    "•1 Insertion sort " +
                    "\n •2 Bubble sort " +
                    "\n •3 Quick sort " +
                    "\n •4 Heap sort " +
                    "\n •5 Merge sort" +
                    "\n •6 all algorits" +
                    "\n in one of these formats 1: 1,2... or 1-2...");


            do
            {
                this.userInput = Console.ReadLine();

                if (Regex.IsMatch(userInput, "^[1-6]$"))
                {
                    if (Int32.TryParse(this.userInput, out int k))
                    {
                        //Console.WriteLine(Int32.Parse(this.userInput));
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

                else if (Regex.IsMatch(this.userInput, "^(([1-5][,]){1,4}?)[1-5]$"))
                {
                    Regex regex = new Regex("[,]");
                    string[] substrings = regex.Split(userInput);
                    foreach (string match in substrings)
                    {
                        if (Int32.TryParse(match, out int k))
                        {
                            //Console.WriteLine(Int32.Parse(match));
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

        public int[] Sort()
        {
            
            
            for (int i=0; i< sortingNumberArr.Length; i++)
            {

                int caseSwitch = sortingNumber[i];
                switch (caseSwitch)
                {
                    case 1://Insertion sort
                        if (all == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Insertion sort");
                            goto case 2;
                        }
                        else 
                        {
                            Console.WriteLine("Insertion sort");
                            break;
                        }

                    case 2: //Bubble sort
                        if (all == true)
                        {
                            Console.WriteLine("Bubble sort");
                            BubbleSort.Sort(arr);
 
                            Console.ResetColor();

                            goto case 3;
                        }
                        else
                        {
                            BubbleSort.Sort(arr);
                            Console.WriteLine("Bubble sort");

                            break;
                        }
                    case 3: //Quick sort
                        if (all == true)
                        {
                            Console.WriteLine("Quick sort");
                            goto case 4;
                        }
                        else
                        {
                            Console.WriteLine("Quick sort");
                            break;
                        }

                    case 4: //Heap sort
                        if (all == true)
                        {
                            Console.WriteLine("Heap sort");
                            goto case 5;
                        }
                        else
                        {
                            Console.WriteLine("Heap sort");
                            break;
                        }

                    case 5: //Merge sort
                        Console.WriteLine("Merge sort");
                        all = false;
                        break;


                    case 6: //all
                        Console.WriteLine("Case 6");
                        all = true;
                        goto case 1;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            return sortingNumberArr; 
        }
    }
}
