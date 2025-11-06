using System;
using System.Collections.Generic;

namespace Primes_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            
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
                    Primes.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", Primes));
        }
    }
}
