using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AliceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation";
            Console.WriteLine("What word would you like to look for in this text?");
            string searchWord = Console.ReadLine();
            string searchWordWhiteRemoved = searchWord.Trim();
            string searchWordLowered = searchWordWhiteRemoved.ToLower();

            string aliceLowered = alice.ToLower();

            int stringLength = searchWordLowered.Length;


            int stringFoundAt = aliceLowered.IndexOf(searchWordLowered);

            string regexPattern = string.Format(@"\b{0}\b", Regex.Escape(searchWordLowered));
            if (Regex.IsMatch(aliceLowered, regexPattern))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
