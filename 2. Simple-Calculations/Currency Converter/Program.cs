using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputconvert = (Console.ReadLine());
            string outputconvert = (Console.ReadLine());

            double BGNtoUSD = 1 / 1.79549;
            double BGNtoEUR = 1 / 1.95583;
            double BGNtoGBP = 1 / 2.53405;
            double USDtoBGN = 1.79549;
            double USDtoEUR = 1.79549 / 1.95583;
            double USDtoGBP = 1.79549 / 2.53405;
            double EURtoBGN = 1.95583;
            double EURtoUSD = 1.95583 / 1.79549;
            double EURtoGBP = 1.95583 / 2.53405;
            double GBPtoBGN = 2.53405;
            double GBPtoEUR = 2.53405 / 1.95583;
            double GBPtoUSD = 2.53405 / 1.79549;
            double total = 0.0;

            if (inputconvert == "BGN")
            {
                if (outputconvert == "USD")
                {
                    total = Math.Round(value * BGNtoUSD, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "EUR")
                {
                    total = Math.Round(value * BGNtoEUR, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "GBP")
                {
                    total = Math.Round(value * BGNtoGBP, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
            }

            if (inputconvert == "USD")
            {
                if (outputconvert == "BGN")
                {
                    total = Math.Round(value * USDtoBGN, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "EUR")
                {
                    total = Math.Round(value * USDtoEUR, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "GBP")
                {
                    total = Math.Round(value * USDtoGBP, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
            }

            if (inputconvert == "EUR")
            {
                if (outputconvert == "BGN")
                {
                    total = Math.Round(value * EURtoBGN, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "USD")
                {
                    total = Math.Round(value * EURtoUSD, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "GBP")
                {
                    total = Math.Round(value * EURtoGBP, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
            }

            if (inputconvert == "GBP")
            {
                if (outputconvert == "BGN")
                {
                    total = Math.Round(value * GBPtoBGN, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "USD")
                {
                    total = Math.Round(value * GBPtoUSD, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
                else if (outputconvert == "EUR")
                {
                    total = Math.Round(value * GBPtoEUR, 2);
                    Console.WriteLine(total + " " + outputconvert);
                }
            }
        }
    }
}