using System;
using System.Collections.Generic;

namespace Prime_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int countPrimes = 0;
            List<int> Primes = new List<int>();

            for (int i = 1; i <= N; i++)
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
                    countPrimes++;
                    Primes.Add(i);
                }
            }
            

            for (int r = 1; r <= countPrimes; r++)
            {
                for (int c = 1; c <= Primes[r-1]; c++)
                {
                    if (Primes.Contains(c))
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }

                }
                Console.WriteLine();
            }



        }
    }
}
