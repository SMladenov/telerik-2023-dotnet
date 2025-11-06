using System;
using System.Diagnostics;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    result += input[i];
            //}

            //1790

            string input = Console.ReadLine();

            int backIndex = input.Length - 1;

            for (int i = 0; i <= input.Length / 2; i++)
            {
                
                if (input[i] != input[backIndex])
                {
                    
                    Console.WriteLine($"{input} : false");
                    return;
                }
                backIndex--;
            }
            Console.WriteLine($"{input} : true");



        }
    }
}
