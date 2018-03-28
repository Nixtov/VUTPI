using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
           

            double sN = n * 0.65;
            double sM = m * 2.7;
            double bulb = Math.Floor(n * 0.65) * 0.2;
            double diff = Math.Abs(budget - (sN + sM + bulb));

            if (sN + sM + bulb <= budget)
            {
                Console.WriteLine("You got this, {0:f2} money left!", diff);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:f2} more!", diff);
            }
        }
    }
}
