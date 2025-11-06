using System;
using System.Numerics;

namespace Above_the_Main_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[N, N];

            BigInteger rowValue = 1;
            BigInteger colValue = 1;

            for (int i = 0; i < N; i++)
            {

                matrix[i, 0] = rowValue;
                rowValue *= 2;

                for (int c = 1; c < N; c++)
                {
                    colValue *= 2;
                    matrix[i, c] = colValue;
                }
                colValue = rowValue;
            }

            BigInteger counterAbove = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {

                        for (int c = j + 1; c < matrix.GetLength(1); c++)
                        {
                            counterAbove += matrix[i, c];
                        }
                    }
                }
            }

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine(counterAbove);
        }
    }
}
