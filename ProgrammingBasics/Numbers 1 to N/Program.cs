using System;

namespace Numbers_1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i < N)
                {
                    Console.Write($"{i} ");
                }
                else if (N == i)
                {
                    Console.Write($"{i}");
                }
            }


            //    Print(N, "elee: ");



            //}

            //private static void Print(int N, string a)
            //{
            //    Console.Write(a);
            //    for (int i = 1; i <= N; i++)
            //    {
            //        Console.Write($"{i} ");
            //    }

        }

    }
}
