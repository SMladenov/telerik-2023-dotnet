using System;

namespace Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            double subtracting = a - b;
            double product = a * b;
            double remainder = a % b;
            double Pow = Math.Pow(a, b);

            Console.WriteLine(sum);
            Console.WriteLine(subtracting);
            Console.WriteLine(product);
            Console.WriteLine(remainder);
            Console.WriteLine(Pow);

        }
    }
}
