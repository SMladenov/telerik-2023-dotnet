using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine();

            //List<string> elements = input.Split(',')
            //    .ToList();

            //List<string> result = new List<string>();

            //for (int i = 0; i < elements.Count; i++)
            //{
            //    if (result.Contains(elements[i]))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        result.Add(elements[i]);
            //    }
            //}

            //Console.WriteLine(string.Join(',', result));


            //result = elements.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

            //Console.WriteLine(string.Join(",", result));

            //List<string> noDuplicates = new List<string>();


            //for (int i = 0; i < elements.Count; i++)
            //{

            //    string currentElement = elements[i];
            //    //bool isUnique = true;

            //    for (int j = 0; j < elements.Count; j++)
            //    {

            //        if (j == i)
            //        {
            //            continue;
            //        }
            //        if (currentElement == elements[j])
            //        {

            //            noDuplicates.Add(currentElement);
            //            elements.RemoveAll(x => x == currentElement);
            //            break;
            //        }

            //    }

            //}

            //Console.WriteLine(string.Join(',', noDuplicates));

            // 1,2,3,4,5,6,7,8,9

            //string input = Console.ReadLine();

            //List<int> numbers = input.Split(' ')
            //    .Select(x => int.Parse(x))
            //    .ToList();


            //numbers.Sort();
            //numbers.Reverse();
            //var res = numbers.Take(2);
            //Console.WriteLine(String.Join(',', res));


            string input = Console.ReadLine();

            List<string> numbers = input.Split(',')
                
                .ToList();

            List<string> noDuplicates = new List<string>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (noDuplicates.Contains(numbers[i]))
                {
                    continue;
                }
                else
                {
                    noDuplicates.Add(numbers[i]);
                }
            }

            //Console.WriteLine(String.Join(',', noDuplicates));

            for (int i = 0; i < noDuplicates.Count; i++)
            {
                if (i == noDuplicates.Count - 1)
                {
                    Console.Write(noDuplicates[i]);
                    continue;
                }
                Console.Write($"{noDuplicates[i]},");
            }
        }
    }
}
