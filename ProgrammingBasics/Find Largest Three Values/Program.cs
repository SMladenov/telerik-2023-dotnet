using System;

namespace Find_Largest_Three_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int firstNumber = int.MinValue;
            int secondNumber = int.MinValue;
            int thirdNumber = int.MinValue;

            for (int i = 1; i <= N; i++)
            {
                int number = int.Parse(Console.ReadLine());
               
                if(number >= firstNumber)
                {
                    secondNumber = firstNumber;
                    thirdNumber = secondNumber;
                    firstNumber = number;
                    
                }
                else if(number >= secondNumber)
                {
                    thirdNumber = secondNumber;
                    secondNumber = number;
                }
                else if(number >= thirdNumber)
                {
                    thirdNumber = number;
                }

            }

            Console.Write($"{firstNumber}, ");
            Console.Write($"{secondNumber} ");
            Console.Write($"and {thirdNumber}");
        }
    }
}
