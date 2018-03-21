    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace OddEvenSum
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int oddSum = 0;
                int evenSum = 0;
                for (int i = 0; i < n; i++)
                {
                    int nums = int.Parse(Console.ReadLine());
                    if (i % 2 == 0) oddSum += nums;
                    else evenSum += nums;
                }
                if (oddSum == evenSum) Console.WriteLine("yes sum = " + evenSum);
                else Console.WriteLine("no diff = {0}", Math.Abs(oddSum - evenSum));

            }
        }
    }
