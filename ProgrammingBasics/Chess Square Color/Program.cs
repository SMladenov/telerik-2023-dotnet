using System;

namespace Chess_Square_Color
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var L = Console.ReadLine();
            int R = int.Parse(Console.ReadLine());

            bool isEven = R % 2 == 0;

            if ((L == "a" || L == "c" || L == "e" || L == "g") && !isEven)
            {
                Console.WriteLine("dark");
            }
            else if ((L == "b" || L == "d" || L == "f" || L == "h") && isEven)
            {
                Console.WriteLine("dark");
            }
            else
            {
                Console.WriteLine("light");
            }

        }
    }
}
