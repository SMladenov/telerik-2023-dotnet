using System;
using System.Collections.Generic;
using System.Linq;

namespace Alone_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alone Numbers
            List<int> list = Console.ReadLine()
                               .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x => int.Parse(x))
                               .ToList();
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= list.Count - 2; i++)
            {
                if (list[i] == number)
                {
                    if (list[i - 1] != number && list[i + 1] != number)
                    {
                        list[i] = Math.Max(list[i - 1], list[i + 1]);
                    }

                }

            }

            string result = String.Join(", ", list);
            Console.WriteLine($"[{result}]");

        }
    }
}
