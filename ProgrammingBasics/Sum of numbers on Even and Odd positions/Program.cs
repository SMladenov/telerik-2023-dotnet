using System;

namespace Sum_of_numbers_on_Even_and_Odd_positions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much numbers: ");
            int n = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven = numbers + sumEven;
                }
                else
                {
                    sumOdd = numbers + sumOdd;
                }

            }
            if (sumEven == sumOdd)
            {
                int sumTotal = sumEven + sumOdd;
                Console.WriteLine($"Yes, the total sum is {sumTotal}");
            }
            else
            {
                int difference = Math.Abs(sumEven - sumOdd);
                Console.WriteLine($"No, difference is {difference}");
            }
        }
    }
}
