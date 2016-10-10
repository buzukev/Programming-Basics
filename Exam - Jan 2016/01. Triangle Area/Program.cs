using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double a = Math.Max(x2, x3) - Math.Min(x2, x3);
            double h = y1 - y2;
            double S = a * h / 2;
            if (S < 0)
            {
                S *= -1;
            }
            Console.WriteLine(S);
        }
    }
}