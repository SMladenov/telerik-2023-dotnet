using System;
using System.Collections.Generic;
using System.Linq;

namespace Symmetric_Arrays
{
    internal class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                List<int> list = input.Split(' ')
                .Select(x => int.Parse(x))
                .ToList();

                int lastIndex = list.Count - 1;
                bool isSymmetric = true;
                for (int j = 0; j <= list.Count / 2; j++)
                {
                    ///gasddsa
                    if (list[j] != list[lastIndex])
                    {
                        isSymmetric = false;
                        break;
                    }
                    lastIndex--;
                }

                if (isSymmetric)
                {
                    Console.WriteLine("Yes");
                }
                else if (isSymmetric == false)
                {
                    Console.WriteLine("No");
                }
            }

        }
    }
}
