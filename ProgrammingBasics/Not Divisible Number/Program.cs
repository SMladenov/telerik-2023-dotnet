using System;

namespace Not_Divisible_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{

            //    if (i % 3 == 0 || i % 7 == 0)
            //    {
            //        continue;
            //    }

            //        Console.Write($"{i} ");

            //}

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                bool i3 = i % 3 == 0;
                bool i7 = i % 7 == 0;

                if (i3 || i7)
                {
                    continue;
                }
                Console.Write($"{i} ");

            }


        }
    }
}
