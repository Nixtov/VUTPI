using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inputCur = Console.ReadLine();
            string outputCur = Console.ReadLine();
            double result = 0;
        if (inputCur.Equals("km"))
            {
                num = num / 0.001;
            }
        if (inputCur.Equals("mm"))
            {
                num = num / 1000;
            }
        if (inputCur.Equals("cm"))
            {
                num = num / 100;
            }
        if (inputCur.Equals("mi"))
            {
                num = num / 0.000621371192;
            }
        if (inputCur.Equals("in"))
            {
                num = num / 39.3700787;
            }
        if (inputCur.Equals("ft"))
            {
                num = num / 3.2808399;
            }
        if (inputCur.Equals("yd"))
            {
                num = num / 1.0936133;
            }
            if (outputCur.Equals("km"))
            {
                num = num * 0.001;
            }
            if (outputCur.Equals("mm"))
            {
                num = num * 1000;
            }
            if (outputCur.Equals("cm"))
            {
                num = num * 100;
            }
            if (outputCur.Equals("mi"))
            {
                num = num * 0.000621371192;
            }
            if (outputCur.Equals("in"))
            {
                num = num * 39.3700787;
            }
            if (outputCur.Equals("ft"))
            {
                num = num * 3.2808399;
            }
            if (outputCur.Equals("yd"))
            {
                num = num * 1.0936133;
            }
            Console.WriteLine("{0}", num);
        }
    }
}
