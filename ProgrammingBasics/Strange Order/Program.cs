using System;
using System.Collections.Generic;
using System.Linq;

namespace Strange_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = input.Split(',')
                 .Select(x => int.Parse(x))
                 .ToList();

            List<int> negative = new List<int>();
            List<int> zero = new List<int>();
            List<int> positive = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber < 0)
                {
                    negative.Add(currentNumber);
                }
                if (currentNumber == 0)
                {
                    zero.Add(currentNumber);
                }
                if (currentNumber > 0)
                {
                    positive.Add(currentNumber);
                }
            }

            List<int> result = negative.Concat(zero).Concat(positive).ToList();

            Console.WriteLine(string.Join(',', result));

        }
    }
}
