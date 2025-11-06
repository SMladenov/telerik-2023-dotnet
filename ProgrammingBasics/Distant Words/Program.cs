using System;

namespace Distant_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int totalSumDifference = 0;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                int sumOfWords = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    int numericValue = word[j] - '\'';
                    sumOfWords += numericValue;
                }

                int distance = Math.Abs(target - sumOfWords);
                totalSumDifference += distance;
                Console.WriteLine($"{word} {distance}");
            }
            
            double avg = totalSumDifference / double.Parse(n.ToString());

            Console.WriteLine($"{avg:f2}");

        }
    }
}
