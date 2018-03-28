using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulBasketball
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int redC = 0;
            int oraC = 0;
            int yC = 0;
            int wC = 0;
            int blC = 0;
            int othC = 0;
            for (int i = 0; i < n; i++)
            {
                string bC = Console.ReadLine();
                if (bC == "red")
                {
                    sum += 5 ;
                    redC += 1;
                }
               else if (bC == "orange")
                {
                    sum += 10;
                    oraC += 1;
                }
              else if (bC == "yellow")
                {
                    sum += 15;
                    yC += 1;
                }
             else if (bC == "white")
                {
                    sum += 20;
                    wC += 1;
                }
              else if (bC == "black")
                {
                    sum = sum / 2;
                    blC += 1;
                }
                else
                {
                    othC += 1;
                }
            }
            Console.WriteLine("Total points: " + sum);
            Console.WriteLine("Points from red balls: {0}", redC);
            Console.WriteLine("Points from orange balls: {0}", oraC);
            Console.WriteLine("Points from yellow balls: {0}", yC);
            Console.WriteLine("Points from white balls: {0}", wC);
            Console.WriteLine("Other colors picked: {0}", othC);
            Console.WriteLine("Divides from black balls: {0}", blC);
        }
    }
}
