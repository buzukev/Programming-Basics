using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i%2 == 0)
                {
                    sumOdd += num;
                }
                else
                {
                    sumEven += num;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sumEven - sumOdd));
            }
        }
    }
}