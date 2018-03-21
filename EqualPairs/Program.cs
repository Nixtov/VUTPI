using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            int sum = 0;
            Boolean isEquals = true;
            int difference = 0;
            int maxDifference = 0;

            for (int i = 0; i < pairs; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    sum = a + b;
                }
                else
                {
                    if (a + b != sum)
                    {
                        isEquals = false;
                        difference = Math.Abs(a + b - sum);
                        if (difference > maxDifference)
                        {
                            maxDifference = difference;
                        }
                    }
                    sum = a + b;
                }
            }
            if (isEquals)
                Console.WriteLine("Yes, value = " + sum);
            else Console.WriteLine("No, maxdiff = " + maxDifference);
        }
    }
}
