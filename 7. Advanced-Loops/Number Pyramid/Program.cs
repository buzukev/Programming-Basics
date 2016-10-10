using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            bool hasEnded = false;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col > 0)
                    {
                        Console.Write(num + " ");
                        if (num == n)
                        {
                            hasEnded = true;
                            break;
                        }
                        num++;
                    }
                }
                Console.WriteLine();
                if (num > n || hasEnded)
                {
                    break;
                }
            }
        }
    }
}