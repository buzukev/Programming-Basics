using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int b = input % 10;
            int a = input / 10;
            if (input >= 0 && input <= 100)
            {
                if (input == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (input <= 10)
                {
                    Console.WriteLine(ones[input]);
                }
                else if (input < 20)
                {
                    Console.WriteLine(teens[b - 1]);
                }
                else if (b == 0)
                {
                    Console.WriteLine(tens[a - 2]);
                }
                else if (input > 20)
                {
                    Console.WriteLine(tens[a - 2] + " " + ones[b]);
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}