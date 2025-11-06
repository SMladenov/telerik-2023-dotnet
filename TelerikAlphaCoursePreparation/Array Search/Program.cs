using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> list = input.Split(',').Select(x => int.Parse(x)).ToList();

            int length = list.Count;

            IEnumerable<int> list2 = Enumerable.Range(1, length).ToList().Except(list).ToArray();

            
            //test change

            Console.WriteLine(string.Join(",", list2));




        }
    }
}
