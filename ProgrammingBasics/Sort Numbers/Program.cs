using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();

            //// 5 3 2 1 3
            //int[] arr = input.Split(", ")
            //    .Select(x => int.Parse(x))
            //    .ToArray();

            //// 0 1 2 3 4 - INDEXES
            //// 0 0 0 0 0
            //int[] result = new int[arr.Length];
            //int indexToRemove = 0;

            //for (int i = 0; i < result.Length; i++)
            //{
            //    int maxNumber = int.MinValue;

            //    // 5 3 2 1 3
            //    for (int y = 0; y < arr.Length; y++)
            //    {
            //        if(arr[y] > maxNumber)
            //        {
            //            maxNumber = arr[y];
            //            indexToRemove = y;
            //        }
            //    }

            //    result[i] = maxNumber;
            //    arr[indexToRemove] = int.MinValue;
            //}

            //Console.WriteLine(String.Join(",", result));


            ////7 6 5 4 3 10
            //string input = Console.ReadLine();

            //List<int> n = input.Split(", ")
            //    .Select(x => int.Parse(x))
            //    .ToList();

            //n.Sort();
            //n.Reverse();

            //Console.WriteLine(string.Join(", ", n));


            string input = Console.ReadLine();

            List<int> numbers = input.Split(',')
                .Select(x => int.Parse(x))
                .ToList();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    Console.Write(numbers[i]);
                    continue;
                }
                Console.Write($"{numbers[i]}, ");
            }

        }
    }
}
