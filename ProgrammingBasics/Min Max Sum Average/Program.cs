using System;

namespace Min_Max_Sum_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double sum = 0;
            double lowest = double.MaxValue;
            double highest = double.MinValue;

            for (int i = 1; i <= N; i++)
            {
                double number = double.Parse(Console.ReadLine());

                sum += number;

                //for (int b = 0; b < number; b++)
                //{
                    if (number > highest)
                    {
                        highest = number;
                    }
                //}

                //for (int c = 0; c < number; c++)
                //{
                    if (number < lowest)
                    {
                        lowest = number;
                    }
                //}

            }

            Console.WriteLine($"min={lowest:f2}");
            Console.WriteLine($"max={highest:f2}");
            double avg = sum / N;
            Console.WriteLine($"sum={sum:f2}");
            Console.WriteLine($"avg={avg:f2}");



        }
    }
}
