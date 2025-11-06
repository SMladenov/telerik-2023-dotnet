using System;
using System.Numerics;

namespace Bounce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int row = int.Parse(input.Split(' ')[0]);
            int col = int.Parse(input.Split(' ')[1]);
            
            BigInteger[,] matrix = new BigInteger[row, col];

            //Filling the matrix
            BigInteger rowFill = 1;
            BigInteger colFill = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = rowFill;
                rowFill *= 2;

                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    colFill *= 2;
                    matrix[i, j] = colFill;
                }
                colFill = rowFill;
            }

            //Bouncing

            int totalLength = row * col;
            string command = "downRight";

            int currentRow = 0;
            int currentCol = 0;
            BigInteger sum = 0;

            for (int i = 0; i < totalLength; i++)
            {
                if (command == "downRight")
                {
                    if (currentRow < row && currentCol < col)
                    {
                        sum += matrix[currentRow, currentCol];
                        currentRow++;
                        currentCol++;

                        if (currentRow == row)
                        {
                            command = "upRight";
                            currentRow--;
                            currentCol--;
                        }
                    }
                }
                if (command == "upRight")
                {
                    if (currentRow < row && currentCol < col)
                    {
                        currentRow--;
                        currentCol++;
                        sum += matrix[currentRow, currentCol];

                        if (currentCol == col - 1)
                        {
                            command = "upLeft";
                        }
                    }
                }
                if (command == "upLeft")
                {
                    if (currentRow > 0 && currentCol > 0)
                    {
                        currentRow--;
                        currentCol--;
                        sum += matrix[currentRow, currentCol];
                    }
                    if (currentRow == 0)
                    {
                        command = "downLeft";
                    }
                }
                if (command == "downLeft")
                {
                    if (currentRow < row && currentCol > 0)
                    {
                        currentRow++;
                        currentCol--;
                        sum += matrix[currentRow, currentCol];
                    }
                    if (currentRow == row - 1 && currentCol == 0)
                    {
                        break;
                    }
                }


            }

            Console.WriteLine(sum);








            ////Printing
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
