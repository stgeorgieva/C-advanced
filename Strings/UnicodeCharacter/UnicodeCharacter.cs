using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
           
            foreach (char s in inputString)
            {
                Console.Write(@"\u{0:x4}", (int)s);
            }
            Console.WriteLine();
        }
    }
}
