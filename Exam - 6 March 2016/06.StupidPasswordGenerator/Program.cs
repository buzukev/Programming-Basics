using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                for (int i1 = 1; i1 <= n1; i1++)
                {
                    for (char i2 = 'a'; i2 < 'a' + n2; i2++)
                    {
                        for (char i3 = 'a'; i3 < 'a' + n2; i3++)
                        {
                            for (int i4 = Math.Max(i, i1) + 1; i4 <= n1; i4++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, i1, i2, i3, i4);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}