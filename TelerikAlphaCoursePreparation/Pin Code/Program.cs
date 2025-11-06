using System;

namespace Pin_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string sub1 = input.Split(' ')[0];
            string sub2 = input.Split(' ')[1];

            string number1 = "";
            string number2 = "";
            


            for (int i = sub1.Length - 1; i >= 0; i--)
            {
                number1 += sub1[i];
                number2 += sub2[i];
            }
            //number1 = number1.Trim('0');

            if (Convert.ToInt32(number1) > Convert.ToInt32(number2))
            {
                string temp = "";
                for (int i = 0; i < number1.Length; i++)
                {
                    if (number1[i] != '0')
                    {
                        temp += number1[i];
                    }
                }
                Console.WriteLine(temp);
            }
            else
            {
                string temp = "";
                for (int i = 0; i < number2.Length; i++)
                {
                    if (number2[i] != '0')
                    {
                        temp += number2[i];
                    }
                }
                Console.WriteLine(temp);
                
            }

        }
    }
}
