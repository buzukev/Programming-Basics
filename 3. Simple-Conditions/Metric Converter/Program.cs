using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string inputmetric = (Console.ReadLine());
            string outputmetric = (Console.ReadLine());

            if (inputmetric == "mm")
            {
                distance = distance / 1000;
            }
            else if (inputmetric == "cm")
            {
                distance = distance / 100;
            }
            else if (inputmetric == "mi")
            {
                distance = distance / 0.000621371192;
            }
            else if (inputmetric == "in")
            {
                distance = distance / 39.3700787;
            }
            else if (inputmetric == "km")
            {
                distance = distance / 0.001;
            }
            else if (inputmetric == "ft")
            {
                distance = distance / 3.2808399;
            }
            else if (inputmetric == "yd")
            {
                distance = distance / 1.0936133;
            }

            if (outputmetric == "mm")
            {
                distance = distance * 1000;
            }
            else if (outputmetric == "cm")
            {
                distance = distance * 100;
            }
            else if (outputmetric == "mi")
            {
                distance = distance * 0.000621371192;
            }
            else if (outputmetric == "in")
            {
                distance = distance * 39.3700787;
            }
            else if (outputmetric == "km")
            {
                distance = distance * 0.001;
            }
            else if (outputmetric == "ft")
            {
                distance = distance * 3.2808399;
            }
            else if (outputmetric == "yd")
            {
                distance = distance * 1.0936133;
            }
            Console.WriteLine(distance + " " + outputmetric);
        }
    }
}