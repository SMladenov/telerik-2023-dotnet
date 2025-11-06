using System;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Robot
            string input;
            int x = 0;
            int y = 0;
            int quadrant = 0;

            while ((input = Console.ReadLine()) != "end")
            {

                if (input == "L")
                {
                    x--;
                }
                if (input == "R")
                {
                    x++;
                }
                if (input == "D")
                {
                    y--;
                }
                if (input == "U")
                {
                    y++;
                }

            }
            if (x < 0 && y > 0)
            {
                quadrant = 1;
            }
            if (x > 0 && y > 0)
            {
                quadrant = 2;
            }
            if (y < 0 && x > 0)
            {
                quadrant = 4;
            }
            if (y < 0 && x < 0)
            {
                quadrant = 3;
            }
            if (x == 0 && y > 0)
            {
                quadrant = 1;
            }
            if (x == 0 && y < 0)
            {
                quadrant = 3;
            }
            if (y == 0 && x > 0)
            {
                quadrant = 2;
            }
            if (y == 0 && x < 0)
            {
                quadrant = 1;
            }
            Console.WriteLine(quadrant);
        }
    }
}
