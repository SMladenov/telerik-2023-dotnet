using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numbers = Console.ReadLine();

            int number1 = numbers[0] - '0';
            int number2 = numbers[1] - '0';
            int number3 = numbers[2] - '0';

            int mult = number1 * number2 * number3;
            int mult1 = (number1 * number2) + number3;
            int mult2 = number1 + (number2 * number3);
            int sum = number1 + number2 + number3;

            int maxNumber = Math.Max(Math.Max(mult, mult1), Math.Max(mult2, sum));

            Console.WriteLine(maxNumber);

            //int[] result = numbers.Select(c => c - '0').ToArray();
        }
    }
}
