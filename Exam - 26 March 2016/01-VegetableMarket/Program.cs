using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double vegetable = vegetablePrice * vegetableKg;
            double fruit = fruitPrice * fruitKg;
            double money = fruit + vegetable;
            double moneyEuro = money / 1.94;

            Console.WriteLine(moneyEuro);
        }
    }
}