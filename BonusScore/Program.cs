using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            Double num = double.Parse(Console.ReadLine());
            Double bonus = 0;
            if (num <= 100)
            {
                bonus += 5;
            }
            if (num > 100 && num <= 1000)
            {
                bonus = num * 0.2;
            }
            if(num > 1000)
            {
                bonus = num * 0.1;
            }
            if ( num % 2 == 0)
            {
                bonus += 1;
            }
            if (num % 10  == 5)
            {
                bonus += 2;
            }
            Console.WriteLine("Bonus score: "+ bonus);
            Console.WriteLine("Total score: "+ (bonus+num));
        }
    }
}
