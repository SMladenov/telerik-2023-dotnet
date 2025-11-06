using System;
using System.Collections.Generic;

namespace Least_Majority_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int N = int.Parse(Console.ReadLine());

                list.Add(N);
            }
            list.Sort();

            int number = list[2];
     


            for (int j = number; j < int.MaxValue; j++)
            {
                int counter = 0;
                if(j % list[0] == 0)
                {
                    counter++;
                }
                if (j % list[1] == 0)
                {
                    counter++;
                }
                if (j % list[2] == 0)
                {
                    counter++;
                }
                if (j % list[3] == 0)
                {
                    counter++;
                }
                if (j % list[4] == 0)
                {
                    counter++;
                }

                if(counter >= 3)
                {
                    Console.WriteLine(j);
                    break;
                }
            }

        }
    }
}
