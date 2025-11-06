using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Sort_All_Zeroes_Moved_at_the_end
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = input.Split(',')
                            .Select(x => int.Parse(x))
                            .ToList();

            List<int> zeroes = new List<int>();
            List<int> withoutZeroes = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber == 0)
                {
                    zeroes.Add(currentNumber);
                }
                else
                {
                    withoutZeroes.Add(currentNumber);
                }
            }

            List<int> combined = withoutZeroes.Concat(zeroes).ToList();

            Console.WriteLine(String.Join(',', combined));

        }
    }
}
