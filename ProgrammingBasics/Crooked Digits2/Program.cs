using System;
using System.Collections.Generic;
using System.Linq;

namespace Crooked_Digits2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string N = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < N.Length; i++)
            {
                if (char.IsDigit(N[i]))
                {
                    sum += N[i] - '0';
                }
            }

            do
            {
                string sum2 = sum.ToString();
                int sumTemp = 0;

                for (int i = 0; i < sum2.Length; i++)
                {
                    sumTemp += sum2[i] - '0';
                    sum = sumTemp;
                }

            } while (sum > 9);
            Console.WriteLine(sum);

        }

    }
}
