using System;
using System.Collections.Generic;
using System.Linq;

namespace Three_Groups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<double> list = input.Split(' ')
            .Select(x => double.Parse(x))
            .ToList();

            List<double> remainder0 = new List<double>();
            List<double> remainder1 = new List<double>();
            List<double> remainder2 = new List<double>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 3 == 0)
                {
                    remainder0.Add(list[i]);
                }
                if (list[i] % 3 == 1)
                {
                    remainder1.Add(list[i]);
                }
                if (list[i] % 3 == 2)
                {
                    remainder2.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ",remainder0));
            Console.WriteLine(string.Join(" ",remainder1));
            Console.WriteLine(string.Join(" ",remainder2));


        }
    }
}
