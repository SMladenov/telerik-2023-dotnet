using System;

namespace Bounce_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int row = int.Parse(input.Split(' ')[0]);
            int col = int.Parse(input.Split(' ')[1]);

            long[,] matrix = new long[row, col];

            //Filling the matrix
            int rowFill = 1;
            int colFill = 1;

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

            ////Filling the matrix with Pow
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[row, col] = (long)Math.Pow(2, row + col);
            //    }
            //}

            int currentRow = 0;
            int currentCol = 0;

            int rowDirection = 1;
            int colDirection = 1;

            long sum = matrix[currentRow, currentCol];

            bool isCornerHit = false;

            //Corner Case

            if (row == 1 || col == 1)
            {
                Console.WriteLine(sum);
                return;
            }
            
            //Bouncing

            while (isCornerHit == false)
            {
                int potentialNextRow = currentRow + rowDirection;
                int potentialNextCol = currentCol + colDirection;

                if (potentialNextRow < 0)
                {
                    //we go down
                    rowDirection = 1;
                }

                if (potentialNextRow >= row)
                {
                    //we go up
                    rowDirection = -1;
                }
                if (potentialNextCol < 0)
                {
                    //we go right
                    colDirection = 1;
                }
                if (potentialNextCol >= col)
                {
                    //we go left
                    colDirection = -1;
                }

                currentRow += rowDirection;
                currentCol += colDirection;

                sum += matrix[currentRow, currentCol];

                if ((currentRow == 0 && currentCol == 0)
                    || (currentRow == 0 && currentCol == col - 1)
                    || (currentRow == row - 1 && currentCol == 0)
                    || (currentRow == row - 1 && currentCol == col - 1))
                {
                    isCornerHit = true;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
