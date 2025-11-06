using System;
using System.Collections.Generic;
using System.Linq;

namespace Most_Occurance_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int[] arr = new int[27];
            
            for (int i = 0; i < input.Length; i++)
            {
                arr[input[i] % 32]++;
            }


            int maxNumber = arr.Max();

            int maxIndex = arr.Reverse().ToList().IndexOf(maxNumber);
            char letter = (char)(maxIndex + 97);

            Console.WriteLine(letter);

        }
    }
}
