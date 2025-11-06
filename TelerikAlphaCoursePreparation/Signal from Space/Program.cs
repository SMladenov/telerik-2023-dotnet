using System;
using System.Collections.Generic;

namespace Signal_from_Space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> list = new List<string>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    list.Add(input[i].ToString());
                }
                if (i + 1 == input.Length - 1)
                {
                    list.Add(input[i + 1].ToString());
                }
            }

            Console.WriteLine(string.Join("", list));


        }
    }
}
