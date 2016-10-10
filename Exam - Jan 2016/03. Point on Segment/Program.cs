using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondfNum = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            var maxNum = Math.Max(firstNum, secondfNum);
            var minNum = Math.Min(firstNum, secondfNum);

            if (point <= maxNum && point >= minNum)
            {
                Console.WriteLine("in");
                var nearpoint1 = Math.Abs(point - firstNum);
                var nearpoint2 = Math.Abs(point - secondfNum);
                Console.WriteLine("{0}", Math.Min(nearpoint1, nearpoint2));
            }
            else if (point > maxNum && point > minNum)
            {
                Console.WriteLine("out");
                Console.WriteLine("{0}", Math.Abs(point - maxNum));
            }
            else if (point < minNum && point < maxNum)
            {
                Console.WriteLine("out");
                Console.WriteLine("{0}", Math.Abs(point - minNum));
            }
        }
    }
}