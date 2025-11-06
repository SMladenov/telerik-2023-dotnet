using System;

namespace Multiplication_Sign2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {

                int howManyNegative = 0;
                if (a < 0)
                {
                    howManyNegative++;
                }
                if (b < 0)
                {
                    howManyNegative++;
                }
                if (c < 0)
                {
                    howManyNegative++;
                }
                if (howManyNegative % 2 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("-");
                }
            }
        }
    }
}
