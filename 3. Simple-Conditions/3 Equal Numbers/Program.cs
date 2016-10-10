using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a != b)
            {
                if (a != c)
                {
                    if (b != c)
                    {
                        Console.WriteLine("no");
                    }
                }
            }
            if (a == b)
            {
                if (b != c)
                {
                    Console.WriteLine("no");
                }
            }
            if (a == c)
            {
                if (b != c)
                {
                    Console.WriteLine("no");
                }
            }
            if (b == c)
            {
                if (a != c)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine("yes");
                }
            }
        }
    }
}