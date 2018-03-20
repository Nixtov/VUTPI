using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches= ");
           Double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters= " + a*2.54);
        }
    }
}
