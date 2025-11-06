using System;

namespace Matrix_Numbers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine(" ");
            }


        }
    }
}
