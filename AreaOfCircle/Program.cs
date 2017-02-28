using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            float theRadius = float.Parse(Console.ReadLine());

            double theArea = Math.PI * theRadius * theRadius;
            Console.WriteLine(string.Format("The area of your circle with a radius of {0} is {1}", theRadius, theArea));
            Console.ReadLine();
        }
    }
}
