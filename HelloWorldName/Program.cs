﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "!");
            Console.ReadLine();
        }
    }
}
