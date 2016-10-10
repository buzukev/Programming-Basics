using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var dplus = d + 5;

            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d <= 25)
                {
                    Console.WriteLine("{0}.{1:d2}", dplus, m);
                }
                else
                {
                    Console.WriteLine("{0}.{1:d2}", dplus - 30, m + 1);
                }
            }
            else if (m == 2)
            {
                if (d <= 23)
                {
                    Console.WriteLine("{0}.{1:d2}", dplus, m);
                }
                else
                {
                    Console.WriteLine("{0}.{1:d2}", dplus - 28, m + 1);
                }
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10)
            {
                if (d <= 26)
                {
                    Console.WriteLine("{0}.{1:d2}", dplus, m);
                }
                else
                {
                    Console.WriteLine("{0}.{1:d2}", dplus - 31, m + 1);
                }
            }
            else if (m == 12)
            {
                if (d <= 26)
                {
                    Console.WriteLine("{0}.{1:d2}", dplus, m);
                }
                else
                {
                    Console.WriteLine("{0}.{1:d2}", dplus - 31, 1);
                }
            }
        }
    }
}