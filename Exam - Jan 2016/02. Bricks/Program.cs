using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var brick = double.Parse(Console.ReadLine());
            var human = double.Parse(Console.ReadLine());
            var volume = double.Parse(Console.ReadLine());

            var kurs = human * volume;
            var kursfinal = brick / kurs;
            Console.WriteLine(Math.Ceiling(kursfinal));
        }
    }
}