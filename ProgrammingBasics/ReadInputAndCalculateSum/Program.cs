using System;
using System.Linq;

namespace ReadInputAndCalculateSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] number = new int[] { 1, 2, 3, 4, 5 };

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            string result = string.Join(" + ", number);
            Console.WriteLine($"{result} = {sum}");

        }
    }
}
