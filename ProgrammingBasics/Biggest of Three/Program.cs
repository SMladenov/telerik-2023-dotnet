using System;

namespace Biggest_of_Three
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            if (a > maxNumber)
            {
                maxNumber = a;
            }
            if (b > maxNumber)
            {
                maxNumber = b;
            }
            if (c > maxNumber)
            {
                maxNumber = c;
            }
            Console.WriteLine(maxNumber);

        }
    }
}
