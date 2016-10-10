using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthplayground = double.Parse(Console.ReadLine());
            double widthplate = double.Parse(Console.ReadLine());
            double lengthplate = double.Parse(Console.ReadLine());
            double widthhbench = double.Parse(Console.ReadLine());
            double lengthbench = double.Parse(Console.ReadLine());

            double area = lengthplayground * lengthplayground;
            double areabench = widthhbench * lengthbench;
            double areacover = area - areabench;
            double areaplate = lengthplate * widthplate;
            double plate = areacover / areaplate;
            double time = 0.2 * plate;

            Console.WriteLine(plate);
            Console.WriteLine(time);
        }
    }
}