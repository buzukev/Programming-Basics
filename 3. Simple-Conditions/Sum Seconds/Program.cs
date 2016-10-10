using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int player3 = int.Parse(Console.ReadLine());
            int total = player1 + player2 + player3;
            int seconds = total % 60;
            int minutes = total / 60;
            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}