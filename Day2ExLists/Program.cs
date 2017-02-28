using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allOfThem = { 1, 2, 3, 10, 20, 30, 55, 73, 81, 90 };
            List<int> bunchOfInts = new List<int>(allOfThem);
            int sum = 0;
            foreach (int anumber in bunchOfInts)
            {
                if (anumber % 2 == 0)
                {
                    sum += anumber;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
