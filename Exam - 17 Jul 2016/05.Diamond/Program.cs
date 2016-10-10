using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dot = n;
            var star = 3 * n;
            var dot1 = 1;
            var star1 = (5 * n) - (2 * dot1) - 2;

            Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('*', star));
            for (int row = 1; row <= n - 1; row++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dot - 1), new string('.', star));
                dot--;
                star += 2;
            }
            Console.WriteLine("{0}", new string('*', 5 * n));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dot1), new string('.', star1));
                dot1++;
                star1 -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', ((5 * n) - (n - 2)) / 2), new string('*', n - 2));
        }
    }
}