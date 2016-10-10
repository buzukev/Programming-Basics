using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            var people = int.Parse(Console.ReadLine());
            var transport = 0.0;
            var ticket = 0.0;

            if (people >= 1 && people <= 4)
            {
                transport = 0.75 * budget;
                var diff = budget - transport;
                if (type == "normal")
                {
                    ticket = 249.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
                else if (type == "vip")
                {
                    ticket = 499.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
            }
            else if (people >= 5 && people <= 9)
            {
                transport = 0.60 * budget;
                var diff = budget - transport;
                if (type == "normal")
                {
                    ticket = 249.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
                else if (type == "vip")
                {
                    ticket = 499.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
            }
            else if (people >= 10 && people <= 24)
            {
                transport = 0.50 * budget;
                var diff = budget - transport;
                if (type == "normal")
                {
                    ticket = 249.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
                else if (type == "vip")
                {
                    ticket = 499.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
            }
            else if (people >= 25 && people <= 49)
            {
                transport = 0.40 * budget;
                var diff = budget - transport;
                if (type == "normal")
                {
                    ticket = 249.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
                else if (type == "vip")
                {
                    ticket = 499.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
            }
            else if (people >= 50)
            {
                transport = 0.25 * budget;
                var diff = budget - transport;
                if (type == "normal")
                {
                    ticket = 249.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
                else if (type == "vip")
                {
                    ticket = 499.99;
                    var tick = ticket * people;
                    var difftick = diff - tick;
                    if (difftick > 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", difftick);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(difftick));
                    }
                }
            }
        }
    }
}