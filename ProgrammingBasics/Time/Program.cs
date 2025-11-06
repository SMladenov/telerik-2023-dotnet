using System;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double d = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());

            double totalSecondsPerDay = d * 24 * 60 * 60;
            double totalSecondsPerHour = h * 60 * 60;
            double totalSecondsPerMinute = m * 60;

            Console.WriteLine($"{totalSecondsPerDay + totalSecondsPerHour + totalSecondsPerMinute + s}");

        }
    }
}
