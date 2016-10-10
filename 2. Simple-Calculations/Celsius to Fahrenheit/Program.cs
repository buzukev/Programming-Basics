using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = Math.Round(celsius * 9 / 5 + 32 , 2);
            Console.WriteLine(fahrenheit);
        }
    }
}