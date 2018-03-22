using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            for (int i = 1; i < n; i++)
            {
                Console.Write(repeatStr(" ", n - i));
                Console.Write(repeatStr("* ", stars));
                stars++;
                Console.WriteLine(); 
            }
            for (int a = 1; a <= n; a++)
            {
                Console.Write(repeatStr(" ", a - 1));
                Console.Write(repeatStr("* ", stars));
                stars--;
                Console.WriteLine();
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