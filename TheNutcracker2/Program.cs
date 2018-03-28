using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNutcracker2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                var space = new string(' ', n - i);
                var space2 = new string(' ', i - 1);
                var slash = new string('/', 1);
                var backSlash = new string('\\', 1);
                Console.Write(space);
                Console.Write(slash);
                Console.Write(space2);
                Console.Write("|  ");
                Console.Write("|");
                Console.Write(space2);
                Console.Write(backSlash);
                Console.WriteLine("");
            }
            Console.Write(" ");
            for (int i = 0; i < n * 2 +2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.Write(" |");
            for (int i = 0; i < n*2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
    }
}
