using System;
using System.Collections.Generic;
using System.Linq;

namespace Good_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string sub1 = input.Split(' ')[0];
            string sub2 = input.Split(' ')[1];
            int sub01 = int.Parse(sub1);
            int sub02 = int.Parse(sub2);

            int counter = 0;

            //for (int i = sub01; i <= sub02; i++)
            //{
            //    if (i >= 1 && i <= 10)
            //    {
            //        counter++;
            //    }
            //    if (i >= 11 && i <= 99)
            //    {
            //        int firstDigit = i / 10;
            //        int secondDigit = i % 10;
            //        if ((firstDigit == 0 && i % secondDigit == 0) ||
            //            (secondDigit == 0 && i % firstDigit == 0))
            //        {
            //            counter++;
            //        }
            //        else if (firstDigit != 0 && secondDigit != 0)
            //        {
            //            if (i % firstDigit == 0 && i % secondDigit == 0)

            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //    if (i >= 100 && i <= 999)
            //    {
            //        int firstDigit = i / 100;
            //        int thirdDigit = i % 10;
            //        int tempSeconDigit = i / 10;
            //        int secondDigit = tempSeconDigit % 10;
            //        if (secondDigit == 0 && thirdDigit == 0)
            //        {
            //            if (i % firstDigit == 0)
            //            {
            //                counter++;
            //            }
            //        }
            //        else if (secondDigit == 0 && thirdDigit != 0)
            //        {
            //            if (i % firstDigit == 0 && i % thirdDigit == 0)
            //            {
            //                counter++;
            //            }
            //        }
            //        else if (secondDigit != 0 && thirdDigit == 0)
            //        {
            //            if (i % firstDigit == 0 && i % secondDigit == 0)
            //            {
            //                counter++;
            //            }
            //        }

            //        else if (firstDigit != 0 && secondDigit != 0 && thirdDigit != 0)
            //        {
            //            if (i % firstDigit == 0 && i % secondDigit == 0 && i % thirdDigit == 0)
            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //}
            Console.WriteLine(counter);
        }
    }
}
