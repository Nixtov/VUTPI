using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Double result = Double.Parse(Console.ReadLine());
            if (result >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
