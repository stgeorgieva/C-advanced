using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSubstringOccurance
{
    class CountSubstringOccurance
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string pattern = Console.ReadLine();
            int fisrtIndex = inputString.IndexOf(pattern, StringComparison.OrdinalIgnoreCase);
            int currentIndex = fisrtIndex;
            int count = 0;
            while (currentIndex != -1)
            {
                count++;
                currentIndex = inputString.IndexOf(pattern,currentIndex + 1, StringComparison.OrdinalIgnoreCase);
            }
            Console.WriteLine(count);
        }
    }
}
