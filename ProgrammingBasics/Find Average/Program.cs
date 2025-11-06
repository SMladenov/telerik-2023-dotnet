using System;

namespace Find_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= N; i++)
            {

                double number = double.Parse(Console.ReadLine());

                sum += number;

            }

            double total = sum / N;
            Console.WriteLine($"{total:f2}");

        }
    }
}
