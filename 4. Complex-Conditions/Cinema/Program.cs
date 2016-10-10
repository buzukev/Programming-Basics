using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            switch (type)
            {
                case "premiere": Console.WriteLine("{0:f2}" + " leva", 12 * c * r); break;
                case "normal": Console.WriteLine("{0:f2}" + " leva", 7.50 * c * r); break;
                case "discount": Console.WriteLine("{0:f2}" + " leva", 5 * c * r); break;
                default:
                    break;
            }
        }
    }
}