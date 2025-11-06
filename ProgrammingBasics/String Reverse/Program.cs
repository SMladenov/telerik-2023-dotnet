using System;
using System.Collections.Generic;

namespace String_Reverse
{
    internal class Program
    {
        private static object list;

        static void Main(string[] args)
        {


            // chislata ot 1 do 100 input, trqbva da go izprintq s dumi

            string input = Console.ReadLine();

            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
