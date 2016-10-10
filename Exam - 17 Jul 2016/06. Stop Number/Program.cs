using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int stopnum = int.Parse(Console.ReadLine());
            for (int i = num2; i >= num1; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stopnum)
                    {
                        break;
                    }
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}