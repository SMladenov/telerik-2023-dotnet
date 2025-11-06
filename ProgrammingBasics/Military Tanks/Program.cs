using System;

namespace Military_Tanks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Military Tanks

            string input = Console.ReadLine();

            int x = 0;
            int y = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "L")
                {
                    x--;
                }
                if (input[i].ToString() == "R")
                {
                    x++;
                }
                if (input[i].ToString() == "D")
                {
                    y--;
                }
                if (input[i].ToString() == "U")
                {
                    y++;
                }
            }
            Console.WriteLine($"({x}, {y})");
        }
    }
}
