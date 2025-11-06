using System;

namespace Simple_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //1 2 3 4
            //12 13 14 5
            //11 16 15 6
            //10 9 8 7


            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int c = n - i - 2; c >= 0; c--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    count++;
                    Console.Write($"{count} ");
                }

                Console.WriteLine();
            }

            //n
            //1 2 3 4
            //12 13 14 5
            //11 16 15 6
            //10 9 8 7

            //int count = 1;
            //int[,] matrix = new int[n, n];

            //int matrixCapacity = n * n;

            //int column = 0;
            //int row = 0;
            //matrix[0, 0] = 1;
            //string command = "right";

            //for (int r = 0; r < matrixCapacity; r++)
            //{
            //    if (command == "right")
            //    {
            //        if (column < n - 1)
            //        {
            //            column++;
            //            count++;
            //            matrix[row, column] = count;
            //        }
            //        if (column == n - 1)
            //        {
            //            command = "down";
            //        }
            //    }

            //    if (command == "down")
            //    {
            //        if (row < n - 1)
            //        {
            //            row++;
            //            count++;
            //            matrix[row, column] = count;
            //        }
            //        if (row == n - 1)
            //        {
            //            command = "left";
            //        }

            //    }

            //    if (command == "left")
            //    {
            //        if (column > 0)
            //        {
            //            column--;
            //            count++;
            //            matrix[row, column] = count;
            //        }
            //        if (column == 0)
            //        {
            //            command = "up";
            //        }

            //    }

            //    if (command == "up")
            //    {
            //        if (row > 1)
            //        {
            //            row--;
            //            count++;
            //            matrix[row, column] = count;
            //        }

            //    }


            //if (column < n)
            //{
            //    matrix[row, column] = count;
            //    // 0,1,2         3 - 1
            //    column++;
            //    count++;
            //    continue;
            //}
            //if (column == n)
            //{

            //    row++;
            //    count++;
            //    matrix[row, column] = count;

            //}

            //for (int r = 0; r < n; r++)
            //{
            //    for (int c = 0; c < n; c++)
            //    {
            //        Console.Write(matrix[r, c] + " ");

            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
