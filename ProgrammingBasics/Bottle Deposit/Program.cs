using System;

namespace Bottle_Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double deposit1 = 0.1d;

            double deposit2 = 0.25d;

            int bottle1 = int.Parse(Console.ReadLine());

            int bottle2 = int.Parse(Console.ReadLine());

            double earn1 = bottle1 * deposit1;

            double earn2 = bottle2 * deposit2;

            double sumEarn = earn1 + earn2;

            Console.WriteLine($"{sumEarn:f2}");

        }
    }
}
