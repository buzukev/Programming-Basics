using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", new string('%', n * 2));

            for (int i = 1; i <= n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", "%", new string(' ', (n * 2) - 2));
                }
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", "%", new string(' ', n - 2), "**");

            for (int i = 1; i <= n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", "%", new string(' ', (n * 2) - 2));
                }
            }
            Console.WriteLine("{0}", new string('%', n * 2));
        }
    }
}