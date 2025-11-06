using System;

namespace Balanced_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string number;

            int char0 = 0;
            int char1 = 0;
            int char2 = 0;
            int sumChar01 = 0;

            int sum = 0;
            do
            {
                number = Console.ReadLine();
                char0 = number[0] - '0';
                char1 = number[1] - '0';
                char2 = number[2] - '0';
                sumChar01 = char0 + char2;

                if (sumChar01 == char1)
                {

                    sum += Convert.ToInt32(number);
                }
                
            } while (sumChar01 == char1);
            Console.WriteLine(sum);
        }
    }
}
