using System;

namespace Exam_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int targetSum = int.Parse(Console.ReadLine());


            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                string number;
                number = i.ToString();

                // trick
                var firstNumber = number[0] - '0';
                var secondNumber = number[1] - '0';
                var thirdNumber = number[2] - '0';

                //int convertfirstNumber = (int)Char.GetNumericValue(firstNumber);
                //int convertsecondNumber = (int)Char.GetNumericValue(secondNumber);
                //int converthirdNumber = (int)Char.GetNumericValue(thirdNumber);

                int sum = firstNumber + secondNumber + thirdNumber;

                if (sum == targetSum)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
