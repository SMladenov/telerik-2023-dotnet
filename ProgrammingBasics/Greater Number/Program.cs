using System;
using System.Collections.Generic;
using System.Linq;

namespace Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Greater Number
            string input1 = Console.ReadLine();
            List<int> numbers1 = input1.Split(',')
                            .Select(x => int.Parse(x))
                            .ToList();
            string input2 = Console.ReadLine();
            List<int> numbers2 = input2.Split(',')
                           .Select(x => int.Parse(x))
                           .ToList();

            for (int i = 0; i < numbers1.Count; i++)
            {
                int j = numbers2.IndexOf(numbers1[i]);

                for (int c = j; c < numbers2.Count; c++)
                {
                    if (numbers2[c] > numbers2[j])
                    {
                        numbers1[i] = numbers2[c];
                        break;
                    }
                    if (numbers2[c] <= numbers2[j])
                    {
                        numbers1[i] = -1;

                    }
                }
            }
            Console.WriteLine(string.Join(",", numbers1));
        }
    }
}
