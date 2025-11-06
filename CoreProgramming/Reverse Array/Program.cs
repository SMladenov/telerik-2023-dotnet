using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //List<int> list = input.Split(' ')
            //    .Select(x => int.Parse(x))
            //                .ToList();
            //list.Reverse();

            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    Console.Write($"{list[i]}, ");
            //}
            //Console.Write(list[list.Count - 1]);




            //string input = Console.ReadLine();
            //string[] tempArray = input.Split(' ');
            //int[] array = new int[tempArray.Length];
            //for (int i = 0; i < tempArray.Length; i++)
            //{
            //    array[i] = int.Parse(tempArray[i]);
            //}

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //array.Reverse();

            int n = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[n - i];
                array[n - i] = temp;
            }

            Console.WriteLine(string.Join(", ", array));

        }
    }
}
