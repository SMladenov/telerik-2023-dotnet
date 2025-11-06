using System;
using System.Collections.Generic;

namespace Prime_Factors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    primeFactors.Add(i);
                }


            }


            for (int i = 0; i < primeFactors.Count; i++)
            {
                Console.WriteLine(i);
            }








        }
    }
}
