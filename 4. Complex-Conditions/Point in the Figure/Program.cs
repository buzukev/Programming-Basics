using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = h;
            double y2 = h;
            double x3 = h * 2;
            double y3 = h * 2;
            double x4 = h * 3;
            double y4 = h * 3;
            double x5 = h * 4;


            if (x > y1 && x < y4 && y > x1 && y < x2 || x > y2 && x < y3 && y > x1 && y < x5)
            {
                Console.WriteLine("inside");
            }
            else if (x == y1 && y >= x1 && y <= x2 || x >= y1 && x <= y4 && y == x1 || x >= y1 && x <= y2 && y >= x1 && y <= x2 || x >= y3 && x<= y4 && y >= x1 && y <= x2 || x == y2 && y >= x2 && y <= x5 || x == y3 && y >= x2 && y <= x5 || x >= y2 && x <= y3 && y == x5)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}