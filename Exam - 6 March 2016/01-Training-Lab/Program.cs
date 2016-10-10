using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double tableonline = Math.Truncate((widht - 1) / 0.7);
            double line = Math.Truncate(length / 1.2);
            double table = (tableonline * line) - 3;
            Console.WriteLine(table);
        }
    }
}