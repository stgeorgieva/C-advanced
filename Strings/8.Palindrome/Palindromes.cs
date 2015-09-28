using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Palindrome
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new string[] { ",", ".", "?"," ","!"}, StringSplitOptions.RemoveEmptyEntries);
            SortedSet <string> sortedPalindrome = new SortedSet<string>();
            for (int i = 0; i < text.Length; i++)
            {
                char[] charArray = text[i].ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);
                if (text[i] == reversedString)
                {
                    sortedPalindrome.Add(text[i]);
                }
            }
            Console.Write(string.Join(",", sortedPalindrome));
            Console.WriteLine();

        }
    }
}
