using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Hungry_Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double exchrate = double.Parse(Console.ReadLine());
            double pizzaPrice = double.Parse(Console.ReadLine());
            double lasagnaPrice = double.Parse(Console.ReadLine());
            double sandwichPrice = double.Parse(Console.ReadLine());
            double pizzaQuantity = double.Parse(Console.ReadLine());
            double lasagnaQuantity = double.Parse(Console.ReadLine());
            double sandwichQuantity = double.Parse(Console.ReadLine());

            double needmoney = (pizzaPrice / exchrate) * pizzaQuantity + (lasagnaPrice / exchrate) * lasagnaQuantity + (sandwichPrice / exchrate) * sandwichQuantity;

            if (needmoney <= money)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", money - needmoney);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", needmoney - money);
            }
        }
    }
}