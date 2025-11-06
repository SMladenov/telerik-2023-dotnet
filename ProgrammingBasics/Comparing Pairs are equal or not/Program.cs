using System;

namespace Comparing_Pairs_are_equal_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many pairs you will enter: ");
            int n = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                var sum = number1 + number2;

                if (sum > maxValue)
                {
                    maxValue = sum;
                }
                if(sum < minValue)
                {
                    minValue = sum;
                }
            }

            if (maxValue == minValue)
            {
                Console.WriteLine($"Yes, value={maxValue}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxValue-minValue}"); ;
            }

        }
    }
}
