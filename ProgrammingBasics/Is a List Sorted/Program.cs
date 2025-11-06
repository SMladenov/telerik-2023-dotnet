using System;
using System.Collections.Generic;
using System.Linq;

namespace Is_a_List_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<bool> result = new List<bool>();

            for (int i = 1; i <= N; i++)
            {
                // 0,1,2,3
                // 1,2,3,4
                string input = Console.ReadLine();

                List<int> numbers = input.Split(',')
               .Select(x => int.Parse(x))
               .ToList();

                bool isSorted = false;
                for (int j = 0; j < numbers.Count - 1; j++)
                {


                    if (numbers[j] <= numbers[j + 1])
                    {
                        isSorted = true;
                        continue;
                    }
                    else
                    {
                        isSorted = false;
                        break;
                    }


                }
                result.Add(isSorted);
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }


        }
    }
}
