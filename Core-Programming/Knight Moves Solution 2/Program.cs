using System;

namespace Knight_Moves_Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            int[][] moves = new int[8][];
            moves[0] = new int[] { -2, -1 };
            moves[1] = new int[] { -2, 1 };
            moves[2] = new int[] { -1, -2 };
            moves[3] = new int[] { -1, 2 };
            moves[4] = new int[] { 1, -2 };
            moves[5] = new int[] { 1, 2 };
            moves[6] = new int[] { 2, -1 };
            moves[7] = new int[] { 2, 1 };

            int row = 0;
            int col = 0;
            int turns = N * N;
            int counter = 1;
            matrix[row, col] = counter;

            while (counter < turns)
            {
                counter++;
                bool validMoveFound = false;

                for (int i = 0; i < moves.Length; i++)
                {
                    int rowNext = moves[i][0];
                    int colNext = moves[i][1];

                    if (row + rowNext >= N || col + colNext >= N || col + colNext < 0 || row + rowNext < 0)
                    {
                        continue;
                    }
                    if (matrix[row + rowNext, col + colNext] != 0)
                    {
                        continue;
                    }
                    else
                    {
                        validMoveFound = true;
                        row += rowNext;
                        col += colNext;
                        break;
                    }

                }
                if (!validMoveFound)
                {
                    for (int r = 0; r < N; r++)
                    {

                        for (int c = 0; c < N; c++)
                        {
                            if (matrix[r, c] == 0)
                            {
                                row = r;
                                col = c;
                                validMoveFound = true;
                                break;
                            }
                        }
                        if (validMoveFound)
                        {
                            break;
                        }
                    }
                }
                matrix[row, col] = counter;
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
