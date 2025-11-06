using System;

namespace Odd_and_Even_complex_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write how much numbers: ");

            int n = int.Parse(Console.ReadLine());

            double sumEven = 0;
            double sumOdd = 0;

            double oddMinValue = double.MaxValue;
            double oddMaxValue = double.MinValue;

            double evenMinValue = double.MaxValue;
            double evenMaxValue = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven = number + sumEven;

                    if (number > evenMaxValue)
                    {
                        evenMaxValue = number;
                    }
                    if (number < evenMinValue)
                    {
                        evenMinValue = number;
                    }
                }
                else
                {
                    sumOdd = number + sumOdd;

                    if (number > oddMaxValue)
                    {
                        oddMaxValue = number;
                    }
                    if (number < oddMinValue)
                    {
                        oddMinValue = number;
                    }

                }

            }

            Console.WriteLine($"OddSum = {sumOdd}");

            if (oddMinValue < double.MaxValue)
            {
                Console.WriteLine($"Odd min = {oddMinValue}");
            }
            else
            {
                Console.WriteLine("Odd min = NO");
            }
            if (oddMaxValue > double.MinValue)
            {
                Console.WriteLine($"Odd max = {oddMaxValue}");
            }
            else
            {
                Console.WriteLine("Odd max = NO");
            }
            
            Console.WriteLine($"EvenSum = {sumEven}");
            if (evenMinValue < double.MaxValue)
            {
                Console.WriteLine($"Even min = {evenMinValue}");
            }
            else
            {
                Console.WriteLine("Even min = NO");
            }
            if (evenMaxValue > double.MinValue)
            {
                Console.WriteLine($"Even max = {evenMaxValue}");
            }
            else
            {
                Console.WriteLine("Even max = NO");
            }

        }
    }
}
