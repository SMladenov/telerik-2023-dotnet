using System;

namespace Odd_and_Even_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int sumOdd = 0;
            int sumEven = 0;
            bool even = N % 2 == 0;
            bool odd = N % 2 == 1;

            for (int i = 1; i <= N; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (even)
                {
                    for (int b = 1; b <= number; b++)
                    {
                        sumEven += number;
                    }
                }
                else if (odd)
                {
                    for (int c = 1; c <= number; c++)
                    {
                        sumEven += number;
                    }
                }

            }
            Console.WriteLine(sumEven);
            Console.WriteLine(sumOdd);



        }
    }
}
