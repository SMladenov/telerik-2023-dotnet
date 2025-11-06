using System;

namespace Vowel_to_Length_Ratio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string meal;
            
            string resultMeal = "";
            double minRatio = double.MaxValue;
            int resultVowels = 0;
            int resultLetters = 0;

            for (int i = 1; i <= n; i++)
            {
                meal = Console.ReadLine();
                int vowels = 0;

                for (int j = 0; j <= meal.Length - 1; j++)
                {
                    if (meal[j] == 'a' || meal[j] == 'e' || meal[j] == 'i' || meal[j] == 'o' || meal[j] == 'u')
                    {
                        vowels += 1;
                    }
                }

                 double ratio = vowels * 1.0 / meal.Length;

                if (ratio < minRatio)
                {
                    minRatio = ratio;
                    resultMeal = meal;
                    resultVowels = vowels;
                    resultLetters = meal.Length;
                }
                else if (ratio == minRatio)
                {
                    if (vowels > resultVowels)
                    {
                        resultMeal = meal;
                        resultVowels = vowels;
                        resultLetters = meal.Length;
                    }
                    if (vowels == resultVowels)
                    {
                        if (meal.Length > resultLetters)
                        {
                            resultMeal = meal;
                            resultVowels = vowels;
                            resultLetters = meal.Length;
                        }
                    }
                }
            }
            Console.WriteLine($"{resultMeal} {resultVowels}/{resultLetters}");
        }
    }
}
