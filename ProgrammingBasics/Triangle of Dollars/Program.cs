using System;

namespace Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }


        }
    }
}
