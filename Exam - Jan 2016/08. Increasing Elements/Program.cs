using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int prev = 0;
            int maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > prev || i == 0)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                prev = num;

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}