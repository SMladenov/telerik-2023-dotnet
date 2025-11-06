using System;

namespace Biggest_number_of_N_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many numbers");
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {

                int num = int.Parse(Console.ReadLine());
                if (num > maxNumber)
                {
                    maxNumber = num;
                }

            }
            Console.WriteLine(maxNumber);

        }
    }
}
