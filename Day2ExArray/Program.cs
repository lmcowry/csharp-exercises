using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = { 1, 1, 2, 3, 5, 8 };
            foreach (int number in fibo)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
