using System;
using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int factorial = 1;

                for (int j = 1; j <= number; j++)
                {
                    factorial *= j;
                }
                Console.WriteLine(factorial);

            }

        }
    }
}
