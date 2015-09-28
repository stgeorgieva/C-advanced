using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerIndexThanNeighbours
{
    class FirstLargerIndexThanNeighbours
    {
        static void Main()
        {
            string[] numbersAsString = Console.ReadLine().Split();
            int[] numbers = new int[numbersAsString.Length];
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsString[i]);
            }
            //for (int i = 0; i < numbers.Length; i++)
            //{
                Console.WriteLine(FirstLargerIndex(numbers));

            //}
        }

        static int FirstLargerIndex(int[] numArray)
        {
            int j = 1;
            int k = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                bool result;
                if (i == 0)
                {
                    result = numArray[i] > numArray[i + 1];
                }
                else if (i == (numArray.Length - 1))
                {
                    result = numArray[i] > numArray[i - 1];
                }
                else
                {
                    result = (numArray[i] > numArray[i + 1]) && (numArray[i] > numArray[i - 1]);
                }
                if (result)
                {
                    k = i;
                    //return i;
                    break;
                }
                else k = -j;
            }
            return k;
        }
    }
}
