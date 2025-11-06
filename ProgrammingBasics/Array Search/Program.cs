using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = input.Split(',')
                .Select(x => int.Parse(x))
                .ToList();

            int N = numbers.Count;

            IEnumerable<int> numbers2 = Enumerable.Range(1, N).ToList().Except(numbers);

            Console.WriteLine(String.Join(",", numbers2));

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (i == numbers.Count - 1)
            //    {
            //        Console.Write(numbers[i]);
            //        continue;
            //    }
            //    Console.Write($"{numbers[i]},");
            //}

        }
    }
}
