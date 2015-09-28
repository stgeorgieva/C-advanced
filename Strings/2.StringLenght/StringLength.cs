using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int diff = 20 - inputString.Length;

            if (diff > 0)
            {
                Console.WriteLine(inputString + new string('*', diff));
            }
            else if (diff < 0)
            {
                Console.WriteLine(inputString.Substring(0,20));
            }
            else
            {
                Console.WriteLine(inputString);
            }
        }
    }
}
