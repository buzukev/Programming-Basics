using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            input = input.ToLower();

            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double areasquare = Math.Round(a * a, 3);
                Console.WriteLine(areasquare);
            }
            else if (input == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double arearectangle = Math.Round(c * b, 3);
                Console.WriteLine(arearectangle);
            }
            else if (input == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areacircle = Math.Round(r * r * Math.PI , 3);
                Console.WriteLine(areacircle);

            }
            else if (input == "triangle")
            {
                double l = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double areatriangle = Math.Round((l * h / 2) , 3);
                Console.WriteLine(areatriangle);
            }
        }
    }
}