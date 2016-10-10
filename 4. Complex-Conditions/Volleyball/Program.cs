using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double weekend = 48;
            double gameinSofia = (weekend - h) * (3.0 / 4);
            double gameinTown = h;
            double holidaygame = p * (2.0 / 3);
            double playgame = gameinSofia + gameinTown + holidaygame;

            switch (year)
            {
                case "leap":
                    double result = (0.15 * playgame) + playgame;
                    Console.WriteLine(Math.Truncate(result)); break;
                case "normal":
                    Console.WriteLine(Math.Truncate(playgame)); break;
                default:
                    break;
            }
        }
    }
}