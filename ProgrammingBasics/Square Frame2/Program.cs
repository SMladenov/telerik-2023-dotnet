using System;

namespace Square_Frame2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());

            //for (int r = 1; r <= n; r++)
            //{

            //    for (int c = 1; c <= n; c++)
            //    {

            //        if (r == 1 && c == 1)
            //        {
            //            Console.Write("+ ");
            //            continue;
            //        }
            //        if (r == 1 && c == n)
            //        {
            //            Console.Write("+ ");
            //            continue;
            //        }
            //        if (r == n && c == n)
            //        {
            //            Console.Write("+ ");
            //            continue;
            //        }
            //        if (r == n && c == 1)
            //        {
            //            Console.Write("+ ");
            //            continue;
            //        }
            //        if (r != 1 && r != n && (c == 1 || c == n))
            //        {
            //            Console.Write("| ");
            //        }
            //        else
            //        {
            //            Console.Write("- ");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            int n = int.Parse(Console.ReadLine());

            Console.Write("* ");
            for (int r = 0; r <= n - 2; r++)
            {
                Console.Write("- ");
            }
            Console.Write("*");

            Console.WriteLine();
            for (int r = 0; r <= n - 2; r++)
            {
                Console.Write("| ");
                for (int c = 0; c <= n - 2; c++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            Console.Write("* ");
            for (int r = 0; r <= n - 2; r++)
            {
                Console.Write("- ");
            }
            Console.Write("*");
        }
    }
}
