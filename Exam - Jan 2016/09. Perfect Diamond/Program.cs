using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row > 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}