﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            double a = double.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (a <= 100)
            {
                bonus = 5;
            }
            else if (a < 1000)
            {
                bonus = a * 0.20;
            }
            else if (a >= 1000)
            {
                bonus = a * 0.10;
            }
            if (a % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (a % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine("Bonus score: " + bonus);
            Console.WriteLine("Total score: " + (a + bonus));
        }
    }
}