using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string milesDrivenString = Console.ReadLine();
            float milesDrivenFloat = Convert.ToSingle(milesDrivenString);

            Console.WriteLine("How much gas have you used?");
            string gasUsedString = Console.ReadLine();
            float gasUsedFloat = Convert.ToSingle(gasUsedString);

            float milesPerGallon = milesDrivenFloat / gasUsedFloat;

            Console.WriteLine("You're efficiency is " + milesPerGallon + " miles per gallon");
            Console.ReadLine();
        }
    }
}
