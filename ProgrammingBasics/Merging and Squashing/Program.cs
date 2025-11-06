using System;
using System.Collections.Generic;

namespace Merging_and_Squashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Merging and Squashing

            int n = int.Parse(Console.ReadLine());

            List<string> numbers = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber.ToString());
            }

            //10, 20, 30, 40 count = 4 
            //
            //result = N -1 (3)
            //
            //10 - 20
            //20 - 30
            //30 - 40

            List<string> mergedList = new List<string>();
            List<string> squashedList = new List<string>();

            for (int j = 0; j < numbers.Count - 1; j++)
            {
                string firstNumber = numbers[j];
                string secondNumber = numbers[j + 1];

                //string 10
                //strinig 20

                int a = firstNumber[0] - '0'; //1
                int b = firstNumber[1] - '0'; //0
                int c = secondNumber[0] - '0';//2
                int d = secondNumber[1] - '0';//0

                string mergedNumberAsString = b.ToString() + c.ToString();

                int middleNumber = b + c;
                //14 18 16 14 15 10 11
                int midleNumber = middleNumber % 10;

                string squashNumbersAsString = a.ToString() + middleNumber + d.ToString();

                mergedList.Add(mergedNumberAsString);
                squashedList.Add(squashNumbersAsString);
            }

            Console.WriteLine(string.Join(' ', mergedList));
            Console.WriteLine(string.Join(' ', squashedList));


        }
    }
}
