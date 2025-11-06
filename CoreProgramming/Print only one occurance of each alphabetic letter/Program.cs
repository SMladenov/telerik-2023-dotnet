using System;
using System.Collections.Generic;

namespace Print_only_one_occurance_of_each_alphabetic_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "git is a VERSION CONTROL for tracking changes in COMPUTER FILES and coordinating work";
            input = input.ToLower();

            string result = "";

            //foreach (char i in input)
            //{
            //    if (char.IsLetter(i) && !result.Contains(i))
            //    {
            //        result += i;
            //    }
            //}

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && !result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
