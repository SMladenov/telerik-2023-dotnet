using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotate_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int N = int.Parse(Console.ReadLine());

            List<int> numbers = input.Split(',')
                .Select(x => int.Parse(x))
                .ToList();


            //1,2,3,4

            //int timesToRotate = N % numbers.Count;

            //List<int> secondPart = numbers.GetRange(0, timesToRotate);
            //List<int> firstPart = numbers.GetRange(timesToRotate, numbers.Count - timesToRotate); 
            //var result = firstPart.Concat(secondPart).ToList();

            //Console.WriteLine(String.Join(',', result));

            for (int i = 0; i < N; i++)
            {

                int firstNumber = numbers[0];
                numbers.Add(firstNumber);

                numbers.RemoveAt(0);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    Console.Write(numbers[i]);
                    continue;
                }
                Console.Write($"{numbers[i]},");
            }

        }
    }
}
