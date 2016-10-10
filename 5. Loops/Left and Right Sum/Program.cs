using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sumfirst = 0;
            int sumsecond = 0;

            for (int i = 0; i < count * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < count)
                {
                    sumfirst = sumfirst + num;
                }
                else
                {
                    sumsecond = sumsecond + num;
                }
            }
            if (sumsecond == sumfirst)
            {
                Console.WriteLine("Yes, Sum = {0}", sumfirst);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumfirst - sumsecond));
            }
        }
    }
}