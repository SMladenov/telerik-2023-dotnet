using System;

namespace Forest_Road
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int height = 2 * N - 1;

            char[,] matrix = new char[height, N];

            
            int row = 0;

            for (int i = 0; i <= matrix.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = '*';
                        
                    }
                    else
                    {
                        matrix[i, j] = '.';
                    }

                }
                
                row++;

            }
            
            for (int i = N; i < matrix.GetLength(0); i++)
            {
                for (int c = N - 1; c >= 0; c--)
                {
                    if (c == row - 2)
                    {
                        matrix[i, c] = '*';
                    }
                    else
                    {
                        matrix[i, c] = '.';
                    }
                }
                row--;
                
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
