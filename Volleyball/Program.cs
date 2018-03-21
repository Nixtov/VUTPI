using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double games = 0;
            if (year == "leap") games = ((48 - h) * 3.0 / 4.0 + h + p * 2.0 / 3.0) * 1.15;
            else if (year == "normal") games = ((48 - h) * 3.0 / 4.0 + h + p * 2.0 / 3.0);
            Console.WriteLine("{0}",Math.Floor(games));
        }
    }
}
