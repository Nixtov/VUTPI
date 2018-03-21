using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") Console.WriteLine(quantity * 2.5);
                else if (fruit == "apple") Console.WriteLine(quantity * 1.2);
                else if (fruit == "orange") Console.WriteLine(quantity * 0.85);
                else if (fruit == "grapefruit") Console.WriteLine(quantity * 1.45);
                else if (fruit == "kiwi") Console.WriteLine(quantity * 2.7);
                else if (fruit == "pineapple") Console.WriteLine(quantity * 5.5);
                else if (fruit == "grapes") Console.WriteLine(quantity * 3.85);
                else Console.WriteLine("error");
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") Console.WriteLine(quantity * 2.7);
                else if (fruit == "apple") Console.WriteLine(quantity * 1.25);
                else if (fruit == "orange") Console.WriteLine(quantity * 0.9);
                else if (fruit == "grapefruit") Console.WriteLine(quantity * 1.60);
                else if (fruit == "kiwi") Console.WriteLine(quantity * 3);
                else if (fruit == "pineapple") Console.WriteLine(quantity * 5.6);
                else if (fruit == "grapes") Console.WriteLine(quantity * 4.20);
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
