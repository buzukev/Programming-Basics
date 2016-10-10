using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string dayornight = Console.ReadLine();

            double tax = 0.0;

            if (distance < 20)
            {
                if (dayornight == "day")
                {
                    tax = 0.7 + 0.79 * distance;
                    Console.WriteLine(tax);
                }
                else
                {
                    tax = 0.7 + 0.9 * distance;
                    Console.WriteLine(tax);
                }
            }
            else if (distance < 100)
            {
                tax = 0.09 * distance;
                Console.WriteLine(tax);
            }
            else
            {
                tax = 0.06 * distance;
                Console.WriteLine(tax);
            }
        }
    }
}