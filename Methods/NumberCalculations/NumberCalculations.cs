using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class NumberCalculations
    {
        static void Main()
        {
            List<int> sequense = new List<int>();
            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                sequense.Add(int.Parse(numbers[i]));
            }
            Console.WriteLine("The sum is: {0}", GetSum(sequense));
            Console.WriteLine("The average is: {0}", GetAverage(sequense));
            Console.WriteLine("The product is: {0}", GetProduct(sequense));
            Console.WriteLine("The min Elemen is: {0}", GetMinEl(sequense));
            Console.WriteLine("The smax elementum is: {0}", GetMaxEl(sequense));
        }

        // Get the Max Element
        static int GetMaxEl(List<int> numArray)
        {
            int minEl = numArray[0];
            int currEl;
            int maxEl = minEl;
            for (int i = 0; i < numArray.Count; i++)
            {
                currEl = numArray[i];
                if (currEl > minEl)
                {
                    maxEl = currEl;
                }
                else
                {
                    maxEl = minEl;
                }
            }
            return maxEl;

        }

        //Get the Min Element
        static int GetMinEl(List<int> numArray)
        {
            int maxEl = numArray[0];
            int currEl;
            int minEl = maxEl;
            for (int i = 0; i < numArray.Count; i++)
            {
                currEl = numArray[i];
                if (currEl < maxEl)
                {
                    minEl = currEl;
                }
                else
                {
                    minEl = maxEl;
                }
            }
            return minEl;
        }
        
        //Calculate the Sum
        static int GetSum(List<int> numArray)
        {
            int sum = 0;
            for (int i = 0; i < numArray.Count; i++)
            {
                sum += numArray[i];
            }
            return sum;
        }

        //Calculate the Average
        static float GetAverage(List<int> numArray)
        {
            float average = 0;
            float sum = 0;
            for (int i = 0; i < numArray.Count; i++)
            {
                sum += numArray[i];
            }
            average = sum / 2;
            return average;
        }

        //Claculate the Product
        static int GetProduct(List<int> numArray)
        {
            int product = 1;
            for (int i = 0; i < numArray.Count; i++)
            {
                product = product * numArray[i];
            }
            return product;

        }
    }
}
