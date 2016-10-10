using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            bool inrange = (num >= 100 && num <= 200) || num == 0;
            if (!inrange)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}