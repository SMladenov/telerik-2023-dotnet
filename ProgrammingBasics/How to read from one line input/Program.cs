using System;
using System.Collections.Generic;
using System.Linq;

namespace How_to_read_from_one_line_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 3 5 10 0 -4
            Console.WriteLine(Console.ReadLine()
                .Split(" ")
                .Select(n => int.Parse(n))
                .Max());



            //int N = int.Parse(Console.ReadLine());

            ////[]
            ////List<int> numbers = new List<int>();

            //int[] intArray = new int[N];
            ////[0, 0, 0, 0, 0]

            //for (int i = 0; i < N; i++)
            //{
            //    int currentNumber = int.Parse(Console.ReadLine());
            //    intArray[i] = currentNumber;
                
            //    //array
            //    //[ 4, 0, 0, 0, 0]
            //    //[ 4, 7, 0, 0, 0]

            //    //List
            //    //[ 4 ]
            //    //[ 4, 7]
            //}

            int[,] matrix = new int[4, 5];



            // 0 0 0 0 0
            // 0 0 0 0 0
            // 0 0 0 0 0
            // 0 0 0 0 0


            //numbers.Sort();
            //numbers.Reverse();

            //Console.WriteLine($"My sorted numbers {string.Join(", ", numbers)}");

            //Console.WriteLine($"Max number is {numbers.Max()}");
            //Console.WriteLine($"Min number is {numbers.Min()}");
            //Console.WriteLine($"Avg number is {numbers.Average():f2}");

            //1 2
            //var intList = Console.ReadLine()
            //    .Split(" ") // ["1", "2"]
            //    .Select(number => int.Parse(number)) // int.Parse("1") => 1 // int.Parse("2") => IEnumerable<int>[1, 2]
            //    .ToList();

            //int[] array = new int[0];
            //List<int> myLuckyNumbers = new List<int>();

            //List<string> friendsNames = new List<string>();
            //friendsNames.Add("Misho");
            //friendsNames.Remove("Gosho");

            //int[] myArrayLuckyNuymbers = new[] { 1, 2, 3, 4, 5 };
            //List<int> myNumbers = new List<int> { 1, 2, 3, 5, 6 };
            //myNumbers.Max();
            //myNumbers.Average();
            //myNumbers.Min();





            // Task logic
            // We add N numbers  => [1,2,3,4,5,6,7,8,9,10]

            //Console.WriteLine(String.Join(", ", intList));


            //var stringList = Console.ReadLine()
            //    .Split(" ")
            //    .ToList();

            //var charList = Console.ReadLine()
            //    .Split(" ")
            //    .Select(x => char.Parse(x))
            //    .ToList();

            //// Array - fixed length
            //// index   0  1
            ////        [1, 2]


            //// List - dynamic length
            //// index   0  1
            ////        [1, 2]
            ////
            //// input.Add(3);
            ////  [1,2,3]
            //int firstNumber = input[0];
            //int secondNumber = input[1];



        }
    }
}
