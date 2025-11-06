using System;
using System.Collections.Generic;
using System.Linq;

namespace Electronic_message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string sub = input.Split('.')[0];


            
            int tempLength = 0;
            int totalLength = 0;

            for (int i = 0; i < sub.Length; i++)
            {
                if (!char.IsDigit(sub[i]) && !char.IsLetter(sub[i]) && sub[i] != ' ')
                {
                   
                    tempLength++;

                    if (tempLength > totalLength)
                    {
                        totalLength = tempLength;
                    }

                }
                else
                {
                    tempLength = 0;
                }
            }
            Console.WriteLine(totalLength);





        }
    }
}
