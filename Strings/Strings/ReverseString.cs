using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));

        }
    }
}
