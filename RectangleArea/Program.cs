using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long side dimensions:");
            string longSideString = Console.ReadLine();
            float longSideFloat = Convert.ToSingle(longSideString);

            Console.WriteLine("Short side dimensions:");
            string shortSideString = Console.ReadLine();
            float shortSideFloat = Convert.ToSingle(shortSideString);

            float areaOfRectangle = shortSideFloat * longSideFloat;

            Console.WriteLine("A rectangle " + shortSideFloat + " by " + longSideFloat + " has an area of " + areaOfRectangle);
            Console.ReadLine();
        }
    }
}
