using System;

namespace Multiplication_from_N_input
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int resultEven = 1;
            int resultOdd = 1;
            

            for (int i = 1; i <= N; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    resultEven *= numbers;
                }
                else
                {
                    resultOdd *= numbers;
                }

            }

            if (resultEven == resultOdd)
            {
                Console.WriteLine($"yes {resultOdd}");
            }
            else
            {
                Console.WriteLine($"no {resultOdd} {resultEven}");   
            }


        }
    }
}
