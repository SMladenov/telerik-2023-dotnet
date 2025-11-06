using System;

namespace Matrix_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j < i + N; j ++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

        }
    }
}
