using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var grappearea = double.Parse(Console.ReadLine());
            var litterwine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var grappe = area * grappearea;
            var wine = 0.4 * grappe / 2.5;

            if (wine >= litterwine)
            {
                var diffwine = Math.Truncate(wine);
                var diff = Math.Ceiling(wine - litterwine);
                var litterperson = Math.Ceiling(diff / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", diffwine);
                Console.WriteLine("{0} liters left -> {1} liters per person.", diff, litterperson);
            }
            else
            {
                var diff = Math.Ceiling(litterwine - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", diff);
            }
        }
    }
}