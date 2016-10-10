using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int b1 = b;
                    b = a + b;
                    a = b1;
                }
                Console.WriteLine(a);
            }
        }
    }
}