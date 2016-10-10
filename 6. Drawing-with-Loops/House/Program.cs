using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= (n + 1) / 2; i++)
            {
                int count = 0;
                int line = 0;
                if (n % 2 == 0)
                {
                    count = 2;
                }
                else
                {
                    count = 1;
                }
                line = (n - count) / 2;

                Console.Write(new string('-', line));
                Console.Write(new string('*', count));
                Console.WriteLine(new string('-', line));
                for (int j = 1; j < (n + 1) / 2; j++)
                {
                    count = count + 2;
                    line = line - 1;
                    Console.Write(new string('-', line));
                    Console.Write(new string('*', count));
                    Console.WriteLine(new string('-', line));
                }
                for (int k = 0; k <= (n / 2) - 1; k++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
                break;
            }
        }
    }
}