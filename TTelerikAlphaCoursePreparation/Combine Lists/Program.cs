using System;
using System.Collections.Generic;
using System.Linq;

namespace Combine_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            List<string> list1 = input1.Split(',').ToList();
            string input2 = Console.ReadLine();
            List<string> list2 = input2.Split(',').ToList();

            List<string> list3 = new List<string>();

            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1[i]);
                list3.Add(list2[i]);
            }

            Console.WriteLine(string.Join(",", list3));
        }
    }
}
