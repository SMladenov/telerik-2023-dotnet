using System;

namespace Module_Division_to_2_without_rest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter how many numbers you will enter: ");
            int n = int.Parse(Console.ReadLine());

            int divisibleBy2 = 0;
            int divisibleBy3 = 0;
            int divisibleBy4 = 0;


            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers % 2 == 0)
                {
                    divisibleBy2++;
                }
                if (numbers % 3 == 0)
                {
                    divisibleBy3++;
                }
                if (numbers % 4 == 0)
                {
                    divisibleBy4++;
                }

            }

            double p1 = divisibleBy2 * 100.0 / n;
            double p2 = divisibleBy3 * 100.0 / n;
            double p3 = divisibleBy4 * 100.0 / n;

            Console.WriteLine($"p1 = {p1:f2}%");
            Console.WriteLine($"p2 = {p2:f2}%");
            Console.WriteLine($"p3 = {p3:f2}%");




        }
    }
}
