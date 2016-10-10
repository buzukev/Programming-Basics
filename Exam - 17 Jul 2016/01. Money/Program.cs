using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuana = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine())/100;
            var bitcoinlv = bitcoin * 1168;
            var yuanaUSD = yuana * 0.15;
            var USDlv = 1.76 * yuanaUSD;
            var moneylv = bitcoinlv + USDlv;
            var moneyEUR = moneylv / 1.95;
            var result = moneyEUR - (moneyEUR * commision);
            Console.WriteLine(result);
        }
    }
}