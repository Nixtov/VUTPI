using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n; j++)
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
