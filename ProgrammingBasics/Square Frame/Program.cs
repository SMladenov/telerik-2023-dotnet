using System;

namespace Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //for (int r = 1; r <= n; r++)
            //{

            //    for (int c = 1; c <= n; c++)
            //    {
            //        if (r == 1 && c == 1)
            //        {
            //            Console.Write("+");
            //            continue;
            //        }
            //        if (r == n && c == n)
            //        {
            //            Console.Write("+");
            //            continue;
            //        }
            //        if (c == n && r == 1)
            //        {
            //            Console.Write('+');
            //            continue;
            //        }
            //        if (r == n && c == 1)
            //        {
            //            Console.Write("+");
            //            continue;
            //        }
            //        if (r != 1 && r != n && (c == 1 || c == n))
            //        {
            //            Console.Write("|");
            //        }
            //        else
            //        {
            //            Console.Write("-");
            //        }


            //    }
            //    Console.WriteLine();
            //}

            for (int r = 1; r <= n; r++)
            {
                if (r == 1 || r == n)
                {
                    Console.Write("+");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine("|");
                }
            }

        }
    }
}
