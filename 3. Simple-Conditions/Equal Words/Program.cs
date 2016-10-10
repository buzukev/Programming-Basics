using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string words2 = Console.ReadLine();
            words = words.ToLower();
            words2 = words2.ToLower();
            if (words == words2)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}