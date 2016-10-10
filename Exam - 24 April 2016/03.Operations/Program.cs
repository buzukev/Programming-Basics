using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            var result = 0.0;

            if (symbol == "+" && N1 != 0 && N2 != 0)
            {
                result = N1 + N2;

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} – {4}", N1, symbol, N2, result, "even");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} – {4}", N1, symbol, N2, result, "odd");
                }
            }
            else if (symbol == "-" && N1 != 0 && N2 != 0)
            {
                result = N1 - N2;

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} – {4}", N1, symbol, N2, result, "even");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} – {4}", N1, symbol, N2, result, "odd");
                }
            }
            else if (symbol == "*" && N1 != 0 && N2 != 0)
            {
                result = N1 * N2;

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} – {4}", N1, symbol, N2, result, "even");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} – {4}", N1, symbol, N2, result, "odd");
                }
            }
            else if (symbol == "/" && N1 != 0 && N2 != 0)
            {
                result = N1 / N2;
                Console.WriteLine("{0} {1} {2} = {3:f2}", N1, symbol, N2, result);
            }
            else if (symbol == "%" && N1 != 0 && N2 != 0)
            {
                result = N1 % N2;
                Console.WriteLine("{0} {1} {2} = {3}", N1, symbol, N2, result);
            }
            else if (N1 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", N2);
            }
            else if (N2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", N1);
            }
        }
    }
}