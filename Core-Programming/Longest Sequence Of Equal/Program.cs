using System;
using System.Collections.Generic;

namespace Longest_Sequence_Of_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //List<int> numbers = new List<int>();

            //for (int i = 0; i < N; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    numbers.Add(n);
            //}

            //Method with return type int
            //int[] numbers = InitializeArray(N);


            //Method without return type ( void )
            int[] numbers = new int[N];
            FillArray(numbers);

            int longest = FindLongestSequence(numbers);
           
            Console.WriteLine(longest);
        }

        static int FindLongestSequence(int[] numbers)
        {
            int sequence = 1;
            int tempSequence = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    tempSequence++;
                }
                else
                {
                    tempSequence = 1;
                }
                if (sequence < tempSequence)
                {
                    sequence = tempSequence;
                }
            }
            return sequence;
        }

        //Adding a method with return type int
        static int[] InitializeArray(int size)
        {
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }

        //Adding a method without return type ( void )
        static void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
