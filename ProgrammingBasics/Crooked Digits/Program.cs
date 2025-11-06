using System;

namespace Crooked_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //123
            string n = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {


                int currentDigit = n[i] - '0';
                if (currentDigit >= 0 && currentDigit <= 9)
                {
                    sum += currentDigit;
                }


            }

            //19
            string sum2 = sum.ToString();

            int result = 0;

            do
            {
                result = 0;

                for (int i = 0; i < sum2.Length; i++)
                {
                    int digit = sum2[i] - '0';
                    result += digit;
                }

                sum2 = result.ToString();


            } while (result > 9);
           

            Console.WriteLine(result);



        }
    }
}
