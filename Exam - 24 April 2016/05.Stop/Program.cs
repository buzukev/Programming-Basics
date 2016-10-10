using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dot = n + 1;
            int line = (2 * n) + 1;

            Console.Write(new string('.', dot));
            Console.Write(new string('_', line));
            Console.WriteLine(new string('.', dot));

            line -= 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', (dot - 1)));
                Console.Write("//");
                Console.Write(new string('_', line));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', dot - 1));
                line += 2;
                dot--;
            }
            Console.WriteLine("{0}{1}{2}{1}{3}", "//", new string('_', ((4 * n) - 5)/2), "STOP!", "\\\\");
            Console.WriteLine("{0}{1}{2}", "\\\\", new string('_', ((4 * n) - 1)), "//");

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', dot), "\\\\", new string('_', line - 2), "//");
                line -= 2;
                dot++;
            }
        }
    }
}
