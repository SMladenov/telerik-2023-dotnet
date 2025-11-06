using System;

namespace Biggest_Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int biggestPrimeNumber = 0;

            for (int i = 2; i <= N; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    biggestPrimeNumber = i;
                }
            }
            Console.WriteLine(biggestPrimeNumber);
            
        }
    }
}
