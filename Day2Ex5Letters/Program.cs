using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Ex5Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] theWords = { "blue", "hatter", "five", "fiver", "forsake", "bitch", "this?" };
            List<string> fiveLetters = new List<string>(theWords);
            foreach (string aword in fiveLetters)
            {
                if (aword.Length == 5)
                {
                    Console.WriteLine(aword);
                }
            }
            Console.ReadLine();
        }
    }
}
