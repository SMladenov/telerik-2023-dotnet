using System;
using System.Collections.Generic;
using System.Linq;

namespace AAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////reading NUMBERS on a single line and splitting them in a List
            //string numbers = Console.ReadLine();

            ////Include System Linq and System Collections Generic

            //List<int> numbersList = numbers.Split(',')
            //                .Select(x => int.Parse(x))
            //                .ToList();

            ////reading WORDS on a single line and splitting them in a List
            //List<string> words = Console.ReadLine()
            //                    .Split(' ')
            //                    .ToList();

            ////reading string from a single line and splitting it by more than 1 Char
            //List<string> list = Console.ReadLine()
            //                    .Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries)
            //                    .ToList();
            //Console.WriteLine(string.Join(' ', list));


            ////reading N number of words and adding them to a List
            //int n = int.Parse(Console.ReadLine());

            //List<string> list = new List<string>();

            //for (int i = 0; i < n; i++)
            //{
            //    string word = Console.ReadLine();

            //    list.Add(word);
            //}

            ////Reading 2 inputs, Concat both lists and print the unique chars
            //string numbers1 = Console.ReadLine();
            //string numbers2 = Console.ReadLine();

            //List<int> list1 = numbers1.Split(',')
            //                  .Select(x => int.Parse(x))
            //                  .ToList();

            //List<int> list2 = numbers2.Split(' ')
            //                  .Select(x => int.Parse(x))
            //                  .ToList();

            //List<int> list3 = list1.Concat(list2).Distinct().ToList();
            //list3.Sort();

            ////for (int i = 0; i < list1.Count; i++)
            ////{
            ////    if (list2.Contains(list1[i]))
            ////    {
            ////        continue;
            ////    }
            ////    else
            ////    {
            ////        list2.Add(list1[i]);
            ////    }
            ////}

            ////list2.Sort();

            //Console.WriteLine(string.Join(' ', list3));



        }
    }
}
