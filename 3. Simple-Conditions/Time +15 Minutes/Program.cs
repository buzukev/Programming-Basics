using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputhours = int.Parse(Console.ReadLine());
            int inputminutes = int.Parse(Console.ReadLine());
            int total = inputhours * 60 + inputminutes + 15;
            int hour = total / 60;
            int minutes = total % 60;
            if (hour >= 24)
            {
                Console.WriteLine("0:{1:00}", hour, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", hour, minutes);
            }
        }
    }
}