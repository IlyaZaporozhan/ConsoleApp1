﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = 8*(2 * Math.Sin(x)) - (2*Math.Cos(x));
            Console.WriteLine(x + " " + F);
            Console.ReadKey();
            return;

        }
    }
}
