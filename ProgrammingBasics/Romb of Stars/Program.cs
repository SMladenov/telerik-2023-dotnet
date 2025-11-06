using System;
using System.Linq;

namespace Romb_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + String.Concat(Enumerable.Repeat("* ", i)));

            }
            for (int b = 1; b <= n - 1; b++)
            {
                Console.WriteLine(new String(' ', b) + String.Concat(Enumerable.Repeat("* ", n - b)));

            }

        }
    }
}
