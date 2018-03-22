using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            int dashes = (n - stars) / 2;
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                Console.Write(repeatStr("-", dashes));
                Console.Write(repeatStr("*", stars));
                Console.WriteLine(repeatStr("-", dashes));
                stars += 2;
                dashes--;
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(repeatStr("*", n - 2));
                Console.WriteLine("|");
            }

        }
        public static String repeatStr(String str, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}