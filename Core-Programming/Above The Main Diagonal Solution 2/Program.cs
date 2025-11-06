using System;

namespace Above_The_Main_Diagonal_Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            long[,] matrix = new long[N, N];

            //long firstCellValue = 1;
            long sum = 0;

            for (int row = 0; row < N; row++)
            {
                //long multiplier = 1;
                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = (long)Math.Pow(2, row + col);
                    //matrix[row, col] = firstCellValue * multiplier;
                    if (col > row)
                    {
                        sum += matrix[row, col];
                    }
                    //multiplier *= 2;
                }
                //firstCellValue *= 2;
            }




            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(sum);
        }
    }
}
