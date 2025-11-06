using System;

namespace Smallest_number_in_N_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much numbers: ");
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine(minNumber);
        }
    }
}
