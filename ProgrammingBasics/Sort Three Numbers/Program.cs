using System;

namespace Sort_Three_Numbers
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

            int sum = a + b + c;
            int sumMath = max + min;
            int mid = sum - sumMath;

            Console.WriteLine($"{max} {mid} {min}");

        }
    }
}
