using System;
using System.Collections.Generic;

namespace ArraySession
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[4];

            array[0] = 2;
            array[1] = 4;
            array[2] = 6;
            array[3] = 8;



            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            int[] newArray = new int[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;

            array[4] = 10;
            array[5] = 12;

            Console.WriteLine(string.Join(' ', array));

            //primitive data types = they have the exact predefined size = int, double, char and etc
            //reference data types = massive, arrays, string, List, Class
            //stack memory = primitive data types
            //dynamic memory = heap memory = reference data types

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(8);
            list.Add(10);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }


        }
    }
}
