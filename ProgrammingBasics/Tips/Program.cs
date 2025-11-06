using System;

namespace Tips
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double tip = 0.1d;

            Console.WriteLine("Please enter your price for the meal:");
            int price = int.Parse(Console.ReadLine());

            double finalTip = price * tip;

            double finalPrice = price + finalTip;

            Console.WriteLine($"{finalPrice}");

        }
    }
}
