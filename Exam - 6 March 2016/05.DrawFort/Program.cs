using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int full = n / 2;
            int empty = 2 * n - 2 * full - 4;

            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", "/", new string('^', full), "\\", new string('_', empty));
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}{1}{0}", "|", new string(' ', 2 * full + empty + 2));
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", "|", new string(' ', full + 1), new string('_', empty));
            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", "\\", new string('_', full), "/", new string(' ', empty));
        }
    }
}