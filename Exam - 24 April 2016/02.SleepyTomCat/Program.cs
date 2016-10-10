using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidayDays = int.Parse(Console.ReadLine());

            int yearDays = 365;
            int workDays = yearDays - holidayDays;
            int playTimeworkDay = workDays * 63;
            int playTimeholiday = holidayDays * 127;
            int playTime = playTimeholiday + playTimeworkDay;
            int playNormTime = 30000;
            int differenceTime = playNormTime - playTime;
            int hours = differenceTime / 60;
            int minutes = differenceTime % 60;

            if (differenceTime > 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(hours), Math.Abs(minutes));
            }
        }
    }
}