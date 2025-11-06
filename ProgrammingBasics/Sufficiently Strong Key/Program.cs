using System;

namespace Sufficiently_Strong_Key
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apiKey = Console.ReadLine();

            int missingLenght = 0;

            if (apiKey.Length < 15)
            {
                missingLenght = 15 - apiKey.Length;
            }

            int upper = 0;
            int lower = 0;
            int number = 0;
            int special = 0;

            for (int i = 0; i < apiKey.Length; i++)
            {
                char charTemp = apiKey[i];
                if (charTemp >= 'A' && charTemp <= 'Z')
                {
                    upper++;
                }
                else if (charTemp >= 'a' && charTemp <= 'z')
                {
                    lower++;
                }
                else if (charTemp >= '0' && charTemp <= '9')
                {
                    number++;
                }
                else
                {
                    special++;
                }
            }

            int missingChars = 0;

            if (upper < 3)
            {
                missingChars += 3 - upper;
            }
            if (lower < 3)
            {
                missingChars += 3 - lower;
            }
            if (number < 3)
            {
                missingChars += 3 - number;
            }
            if (special < 3)
            {
                missingChars += 3 - special;
            }
            if (missingChars > missingLenght)
            {
                Console.WriteLine(missingChars);
            }
            else
            {
                Console.WriteLine(missingLenght);
            }
            //test
        }
    }
}