using System;

namespace Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int wholeNumber = int.Parse(Console.ReadLine());

            int lastDigit = wholeNumber % 10;

            int lastDigit2 = wholeNumber / 10;

            int secondDigit = lastDigit2 % 10;

            int secondDigit2 = lastDigit2 / 10;

            int thirdDigit = secondDigit2 % 10;

            int thirdDigit2 = secondDigit2 / 10;

            int fourthDigit = thirdDigit2 % 10;

            Console.WriteLine($"{lastDigit + secondDigit + thirdDigit + fourthDigit}");

        }
    }
}
