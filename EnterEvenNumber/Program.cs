using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: " + n);
                    break;
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
