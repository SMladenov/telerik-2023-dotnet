using System;

namespace Knight_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            int counter = 1;
            int row = 0;
            int col = 0;
            matrix[0, 0] = 1;

            for (int i = 0; i < N * N; i++)
            {
                //It is very important to have the first validation for out of range before the validation for 0
                //because if swapped it will give error
                if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 0)
                {
                    counter++;
                    matrix[row - 2, col - 1] = counter;
                    row -= 2;
                    col -= 1;
                }
                else if (row - 2 >= 0 && col + 1 < N && matrix[row - 2, col + 1] == 0)
                {
                    counter++;
                    matrix[row - 2, col + 1] = counter;
                    row -= 2;
                    col += 1;
                }
                else if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 0)
                {
                    counter++;
                    matrix[row - 1, col - 2] = counter;
                    row -= 1;
                    col -= 2;
                }
                else if (row - 1 >= 0 && col + 2 < N && matrix[row - 1, col + 2] == 0)
                {
                    counter++;
                    matrix[row - 1, col + 2] = counter;
                    row -= 1;
                    col += 2;
                }
                else if (row + 1 < N && col - 2 >= 0 && matrix[row + 1, col - 2] == 0)
                {
                    counter++;
                    matrix[row + 1, col - 2] = counter;
                    row += 1;
                    col -= 2;
                }
                else if (row + 1 < N && col + 2 < N && matrix[row + 1, col + 2] == 0)
                {
                    counter++;
                    matrix[row + 1, col + 2] = counter;
                    row += 1;
                    col += 2;
                }
                else if (row + 2 < N && col - 1 >= 0 && matrix[row + 2, col - 1] == 0)
                {
                    counter++;
                    matrix[row + 2, col - 1] = counter;
                    row += 2;
                    col -= 1;
                }
                else if (row + 2 < N && col + 1 < N && matrix[row + 2, col + 1] == 0)
                {
                    counter++;
                    matrix[row + 2, col + 1] = counter;
                    row += 2;
                    col += 1;
                }
                else
                {
                    bool isFound = false;
                    for (int r = 0; r < N; r++)
                    {
                        for (int c = 0; c < N; c++)
                        {
                            if (matrix[r, c] == 0)
                            {
                                counter++;
                                matrix[r, c] = counter;
                                row = r;
                                col = c;
                                isFound = true;
                                break;
                            }
                        }
                        if (isFound)
                        {
                            break;
                        }
                    }
                }
            }

            PrintMatrix(matrix);


        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
