using System;
using System.Numerics;

namespace Above_The_Main_Diagonal_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[N, N];

            BigInteger row = 1;
            BigInteger col = 1;

            for (int i = 0; i < N; i++)
            {
                matrix[i, 0] = row;
                row *= 2;

                for (int j = 1; j < N; j++)
                {
                    col *= 2;
                    matrix[i, j] = col;
                }
                col = row;
            }

            BigInteger sumAbove = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sumAbove += matrix[i, j];
                        for (int c = j + 1; c < matrix.GetLength(1); c++)
                        {
                            sumAbove += matrix[i, c];
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

            Console.WriteLine(sumAbove);
        }
    }
}
