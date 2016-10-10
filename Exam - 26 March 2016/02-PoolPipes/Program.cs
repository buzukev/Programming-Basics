using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double volPool = double.Parse(Console.ReadLine());
            double firstPipe = double.Parse(Console.ReadLine());
            double secondPipe = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double Pipe1 = firstPipe * hours;
            double Pipe2 = secondPipe * hours;
            double PipeAll = Pipe1 + Pipe2;

            if (PipeAll <= volPool)
            {
                double fullPool = (PipeAll / volPool) * 100;
                double pipe1 = (Pipe1 / PipeAll) * 100;
                double pipe2 = (Pipe2 / PipeAll) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", fullPool, Math.Round(pipe1, 0), Math.Round(pipe2, 0));
            }
            else
            {
                double overflow = PipeAll - volPool;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overflow);
            }

        }
    }
}