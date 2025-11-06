using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            List<int> numbersList = numbers.Split(' ')
                              .Select(x => int.Parse(x))
                              .ToList();
            int sum = 0;

            for (int i = 0; i < numbersList.Count; i++)
            {
                if ((numbersList[i] % 3 == 0) && (numbersList[i] % 7 == 0))
                {
                    sum += numbersList[i];
                }
            }

            string sumString = sum.ToString();

            int sumFinal = 0;

            for (int i = 0; i < sumString.Length; i++)
            {
                sumFinal += sumString[i] - '0';
            }

            Console.WriteLine(sumFinal);
        }
    }
}
