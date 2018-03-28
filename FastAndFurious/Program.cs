using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastAndFurious
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double n = y * 3.6;
            double m = (v + n);
            double t = (x / v);
            double l = (x / m);
            Console.WriteLine("The truck arrived after {0} hours", Math.Ceiling(t));
            Console.WriteLine("The car arrived after {0} hours", Math.Ceiling(l));
        }
    }
}

