using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }

        static double GetReversedNumber(double num)
        {
            string numToString = num.ToString();
            char[] charArray = numToString.ToCharArray();
            Array.Reverse(charArray);
            numToString = new string(charArray);
            double result = Convert.ToDouble(numToString);
            return result;
        }
    }
}
