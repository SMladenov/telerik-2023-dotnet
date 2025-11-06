using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Game
            string number = Console.ReadLine();

            int firstDigit = number[0] - '0';
            int secondDigit = number[1] - '0';
            int thirdDigit = number[2] - '0';

            int sumAll = firstDigit + secondDigit + thirdDigit;
            int sumFirst = firstDigit + secondDigit * thirdDigit;
            int sumSecond = firstDigit * secondDigit + thirdDigit;
            int multipleAll = firstDigit * secondDigit * thirdDigit;

            int maxNumber = Math.Max(Math.Max(sumAll, sumFirst), Math.Max(sumSecond, multipleAll));

            Console.WriteLine(maxNumber);

        }
    }
}
