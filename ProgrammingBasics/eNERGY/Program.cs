using System;
using System.Collections.Generic;

namespace eNERGY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Energy

            long input = long.Parse(Console.ReadLine());

            List<long> listOfInts = new List<long>();

            while (input > 0)
            {
                listOfInts.Add(input % 10);
                input = input / 10;
            }

            long sumEven = 0;
            long sumOdd = 0;

            for (int i = 0; i < listOfInts.Count; i++)
            {

                if (listOfInts[i] % 2 == 0)
                {
                    sumEven += listOfInts[i];
                }
                if (listOfInts[i] % 2 != 0)
                {
                    sumOdd += listOfInts[i];
                }

            }

            if (sumEven > sumOdd)
            {
                Console.WriteLine($"{sumEven} energy drinks");
            }
            if (sumOdd > sumEven)
            {
                Console.WriteLine($"{sumOdd} cups of coffee");
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine($"{sumEven} of both");
            }
        }
    }
}
