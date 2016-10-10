using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int p = int.Parse(Console.ReadLine());

                if (p % 2 == 0)
                {
                    p1++;
                }
                if (p % 3 == 0)
                {
                    p2++;
                }
                if (p % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:f2}%", p1 / n * 100);
            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
        }
    }
}