using System;
using System.Collections.Generic;
using System.Linq;

namespace Celsius_to_Farenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<double> numbersC = input.Split(' ')
                .Select(x => double.Parse(x))
                .ToList();

            List<double> numbersF = new List<double>();

            for (int i = 0; i < numbersC.Count; i++)
            {
                double currentNumber = numbersC[i];

                double farenheit = currentNumber * 1.8 + 32;

                numbersF.Add(farenheit);
            }

            for (int j = 0; j < numbersF.Count; j++)
            {
                Console.WriteLine(numbersF[j]);
            }
           
        }
    }
}
