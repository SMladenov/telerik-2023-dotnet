using System;

namespace Biggest_Of_Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int result = Math.Max(Math.Max(Math.Max(Math.Max(a, b), c), d), e);

            //int maxValue = int.MinValue;

            //if (a > maxValue)
            //{
            //    maxValue = a;
            //}
            //if (b > maxValue)
            //{
            //    maxValue = b;
            //}
            //if (c > maxValue)
            //{
            //    maxValue = c;
            //}
            //if (d > maxValue)
            //{
            //    maxValue = d;
            //}
            //if (e > maxValue)
            //{
            //    maxValue = e;
            //}
            //Console.WriteLine(maxValue);
        }
    }
}
