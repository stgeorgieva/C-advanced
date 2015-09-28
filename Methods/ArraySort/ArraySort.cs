using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int[] numbersToInt = new int[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersToInt[i] = int.Parse(numbers[i]);
                //tempArray.Add(numbersToInt[i]);

            }
            Console.WriteLine(string.Join(" ", SortArray(numbersToInt)));

        }

        static int[] SortArray(int[] numArray)
        {
            List<int> tempArray = new List<int>();
            int j = 0;
            int MinNumber;
            int MinNumberIndex;
            int SwappedNumber;
            int AvailableIndex;


            for (int i = 0; i < numArray.Length; i++)
            {
               // numbersToInt[i] = int.Parse(numbers[i]);
                tempArray.Add(numArray[i]);

            }

            for (int i = j; i < numArray.Length; i++)
            {
                AvailableIndex = j;
                SwappedNumber = numArray[AvailableIndex];
                MinNumber = tempArray.Min();
                MinNumberIndex = Array.IndexOf(numArray, MinNumber);
                numArray[j] = MinNumber;
                numArray[MinNumberIndex] = SwappedNumber;
                tempArray.Remove(MinNumber);
                j++;
            }
            return numArray;
        }
    }
}
