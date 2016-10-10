using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var washPrice = double.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var present = 0.0;
            var moneySave = 0.0;
            var bonus = 10.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySave += bonus;
                    moneySave -= 1;
                    bonus += 10;
                }
                else
                {
                    present += presentPrice;
                }
            }
            var allmoney = moneySave + present;

            if (allmoney >= washPrice)
            {
                Console.WriteLine("Yes! {0:f2}", allmoney - washPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washPrice - allmoney);
            }
        }
    }
}