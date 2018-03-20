using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 0;

            if (type == "Premiere") result = r * c * 12;
            else if (type == "Normal") result = r * c * 7.50;
            else if (type == "Discount") result = r * c * 5;
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
