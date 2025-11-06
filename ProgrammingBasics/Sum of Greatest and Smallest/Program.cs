using System;

namespace Sum_of_Greatest_and_Smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));

            int min = Math.Min(a, Math.Min(b, c));

            int sum = min + max;

            Console.WriteLine(sum);

        }
    }
}
