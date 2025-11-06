using System;

namespace Matrichka_sam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// 3 2 1
            ///  4 3 2
            ///  5 4 3

            // 1 2 3
            // 8 9 4
            // 7 6 5

            

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = i + N - 1; j >= i; j--)
                {
                    Console.Write($"{j} ");

                }
                Console.WriteLine();
            }
        }
    }
}
