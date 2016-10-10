using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Encoded_Answers
{
    public class EncodedAnswers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = null;
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                string answer;

                if (num % 4 == 0)
                {
                    countA++;
                    answer = "a";
                }
                else if (num % 4 == 1)
                {
                    countB++;
                    answer = "b";
                }
                else if (num % 4 == 2)
                {
                    countC++;
                    answer = "c";
                }
                else if (num % 4 == 3)
                {
                    countD++;
                    answer = "d";
                }
                result += answer;
            }
            Console.WriteLine("{0} ", result);
            Console.WriteLine("Answer A: {0}", countA);
            Console.WriteLine("Answer B: {0}", countB);
            Console.WriteLine("Answer C: {0}", countC);
            Console.WriteLine("Answer D: {0}", countD);
        }
    }
}