using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int areaMin = int.Parse(Console.ReadLine());

            bool print = false;
            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            var a = right - left;
                            var b = bottom - top;
                            var area = a * b;

                            if (area >= areaMin)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                print = true;
                            }

                        }
                    }
                }
            }
            if (print == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}