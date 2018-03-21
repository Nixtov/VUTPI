using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea2D
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);
            double widrh = Math.Max(x1, x2) - Math.Min(x1, x2);
            Console.WriteLine(height*widrh);
            Console.WriteLine(2*(height+widrh));
            Console.WriteLine(Math.Min(y2, y1));

        }
    }
}
