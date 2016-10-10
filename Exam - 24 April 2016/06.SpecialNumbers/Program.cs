using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int i1 = 1; i1 < 10; i1++)
                {
                    for (int i2 = 1; i2 < 10; i2++)
                    {
                        for (int i3 = 1; i3 < 10; i3++)
                        {
                            if (n % i == 0 && n % i1 == 0 && n % i2 == 0 && n % i3 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, i1, i2, i3);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}