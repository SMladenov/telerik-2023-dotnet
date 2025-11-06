using System;
using System.Collections.Generic;
using System.Linq;

namespace Combine_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string input2 = Console.ReadLine();

            List<int> numbers = input.Split(',')
               .Select(x => int.Parse(x))
               .ToList();


            List<int> numbers2 = input2.Split(',')
               .Select(x => int.Parse(x))
               .ToList();

            List<int> combined = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                combined.Add(numbers[i]);

                combined.Add(numbers2[i]);
            }

            Console.WriteLine(string.Join(",", combined));
        }
    }
}
