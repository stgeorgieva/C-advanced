using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
           string[] bannedWordsAsString = Console.ReadLine().Split(new string[] { ",", " "}, StringSplitOptions.RemoveEmptyEntries);
           string text = Console.ReadLine();
           string replaceString = null;
           for (int i = 0; i < bannedWordsAsString.Length; i++)
            {
                string bannedWword = bannedWordsAsString[i];
                string wordToReplace = new string('*', bannedWword.Length);
                replaceString = text.Replace(bannedWword, wordToReplace);
                text = replaceString;
            }
<<<<<<< HEAD
	    // test
=======
	    // Ither test
>>>>>>> c7a950d851035c04be8f2fde440bfe123b4ca2f4
            Console.WriteLine(replaceString);
        }
    }
}
