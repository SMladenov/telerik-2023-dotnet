using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Lying_Sheppard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //odd: 3, even: 4, odd: 6

            List<string> list = Console.ReadLine()
                              .Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
                              .ToList();

            int countTrue = 0;
            int countFalse = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals("odd", StringComparison.OrdinalIgnoreCase))
                {
                    int tempInt = Convert.ToInt32(list[i + 1]);
                    if (tempInt % 2 != 0)
                    {
                        countTrue++;
                    }
                    if (tempInt % 2 == 0)
                    {
                        countFalse++;
                    }

                }
                if (list[i].Equals("even", StringComparison.OrdinalIgnoreCase))
                {
                    int tempInt = Convert.ToInt32(list[i + 1]);
                    if (tempInt % 2 != 0)
                    {
                        countFalse++;
                    }
                    if (tempInt % 2 == 0)
                    {
                        countTrue++;
                    }

                }

            }
            int sumTotal = countTrue + countFalse;

            double percentageTrue = countTrue * 100.0 / sumTotal;

            if (percentageTrue >= 80)
            {
                Console.WriteLine("Not Lying");
            }
            else
            {
                Console.WriteLine("Lying");
            }
           



        }
    }
}
