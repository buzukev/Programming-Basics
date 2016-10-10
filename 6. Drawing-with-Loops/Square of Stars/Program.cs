using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int row = 1; row <= a; row++)
            {
                Console.Write("*");
                for (int col = 1; col < a; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}