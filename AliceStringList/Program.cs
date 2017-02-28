using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceStringList
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation";

            string aliceLowered = alice.ToLower();
            string alicePunctuationRemoved = new string(aliceLowered.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] aliceLoweredList = alicePunctuationRemoved.Split(' ');

            Console.WriteLine("What word would you like to look for in this text?");
            string searchWord = Console.ReadLine();

            string searchWordWhiteRemoved = searchWord.Trim();
            string searchWordLowered = searchWordWhiteRemoved.ToLower();

            Console.WriteLine(aliceLoweredList.Contains(searchWordLowered));

            //bool found = false;

            //foreach (string word in aliceLoweredList)
            //{
            //    if (word == searchWordLowered)
            //    {
            //        found = true;
            //        Console.WriteLine("true");
            //        //instructions were just to print true if at least one occurrence.  so it does a eureka and exits
            //        break;
            //    }
            //}
            //if (found == false)
            //{
            //    Console.WriteLine("false");
            //}
            Console.ReadLine();
        }
    }
}
