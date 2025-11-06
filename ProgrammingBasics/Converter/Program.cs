using System;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double m = double.Parse(Console.ReadLine());

            double kilometers = m * 1.6d;
            double kilometersPerLitre = kilometers / 4.54d;
            double result = Math.Floor(100d / kilometersPerLitre);

            Console.WriteLine($"{result} litres per 100 km");

        }
    }
}
