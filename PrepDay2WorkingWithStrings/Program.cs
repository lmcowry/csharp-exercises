using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepDay2WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            string myString = String.Format("{0:C}", 123.45);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
