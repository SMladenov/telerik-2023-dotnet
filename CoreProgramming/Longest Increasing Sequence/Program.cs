using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxLen = 1;
        int currentLen = 1;

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentLen++;
            }
            else
            {
                currentLen = 1;
            }

            if (currentLen > maxLen)
            {
                maxLen = currentLen;
            }

        }
        Console.WriteLine(maxLen);
    }
}