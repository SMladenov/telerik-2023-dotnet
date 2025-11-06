using System;

namespace Sum_of_whole_numbers_and_print_the_result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much numbers:");
            int n = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
    }
}
