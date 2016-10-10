using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int minutesExam = (examHour * 60) + examMin;
            int minutesArrive = (arriveHour * 60) + arriveMin;
            int diff = minutesArrive - minutesExam;

            if (diff < -30)
            {
                Console.WriteLine("Early");
            }
            else if (diff <= 0)
            {
                Console.WriteLine("On time");
            }
            else if (diff > 0)
            {
                Console.WriteLine("Late");
            }
            if (diff != 0)
            {
                var hour = Math.Abs(diff / 60);
                var min = Math.Abs(diff % 60);
                if (hour > 0)
                {
                    Console.Write("{0}:{1:d2} hours", hour, min);
                }
                if (hour <= 0)
                {
                    Console.Write("{0} minutes", min);
                }
                if (diff > 0)
                {
                    Console.WriteLine(" after the start");
                }
                else
                {
                    Console.WriteLine(" before the start");
                }
            }
        }
    }
}