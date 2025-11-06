using System;

namespace Element_equal_to_the_sum_of_all_other_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much numbers: ");

            int n = int.Parse(Console.ReadLine());

            int sumTotal = 0;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumTotal = sumTotal + number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

            }

            int sumTotal2 = sumTotal - maxNumber;
            if (sumTotal2 == maxNumber)
            {
                Console.WriteLine($"Yes, the max number is {maxNumber}");
            }
            else
            {
                int difference = Math.Abs(sumTotal2 - maxNumber);
                Console.WriteLine($"No, the difference is {difference}");
            }

        }
    }
}
