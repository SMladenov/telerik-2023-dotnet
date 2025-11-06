using System;

namespace _2dArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Console.Write($"{matrix[i, j]} ");
                    Console.Write("{0, 8}", matrix[i, j]); //place holder {0, 4} --- slaga otstoqniq 4 space-a mejdu simvolite
                }
                Console.WriteLine();
            }


        }
    }
}
