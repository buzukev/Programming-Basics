﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("Greater number: " + a);
            }
            else
            {
                Console.WriteLine("Greater number: " + b);
            }
        }
    }
}