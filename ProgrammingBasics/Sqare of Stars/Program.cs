using System;

namespace Sqare_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int b = 1; b <= n; b++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
