using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Average_Below_and_Above_numbers
{
    internal class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<int> numbers = input.Split(',')
                        .Select(x => int.Parse(x))
                        .ToList();

            double average = numbers.Average();


            List<int> below = new List<int>();
            List<int> above = new List<int>();

            foreach (var item in numbers)
            {
                if (item < average)
                {
                    below.Add(item);
                }
                if (item > average)
                {
                    above.Add(item);
                }
            }

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int currentNumber = numbers[i];

            //    if (currentNumber < average)
            //    {
            //        below.Add(currentNumber);
            //    }
            //    if (currentNumber > average)
            //    {
            //        above.Add(currentNumber);
            //    }
            //}

            Console.WriteLine($"avg: {average:f2}");
            Console.WriteLine("below: " + String.Join(",", below));
            Console.WriteLine("above: " + String.Join(",", above));

        }
    }
}
