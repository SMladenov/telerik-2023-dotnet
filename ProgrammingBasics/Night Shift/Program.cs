using System;
using System.Collections.Generic;
using System.Linq;

namespace Night_Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentHour = "";
            int countDrinks = 0;

            while (true)
            {
                string numbers = Console.ReadLine();

                if ((int.Parse(numbers.Split(':')[0]) < 20 || int.Parse(numbers.Split(':')[0]) > 23)
                    && (int.Parse(numbers.Split(':')[0]) < 0 || int.Parse(numbers.Split(':')[0]) > 7))
                {
                    Console.WriteLine("Shift is over");
                    break;
                }

                if (currentHour != numbers.Split(':')[0])
                {
                    currentHour = numbers.Split(':')[0];
                    countDrinks = 0;
                }

                List<int> numbersList = numbers.Split(':')
                              .Select(x => int.Parse(x))
                              .ToList();

                List<string> drinks = new List<string>();

                if ((numbersList[1] - numbersList[0]) % 2 != 0)
                {
                    Console.WriteLine("take a break");
                }
                else
                {
                    if ((numbersList[0] + numbersList[1]) % 2 == 0)
                    {
                        drinks.Add("coffee");
                        countDrinks++;
                    }
                    if ((numbersList[1] > numbersList[0]))
                    {
                        drinks.Add("energy drink");
                        countDrinks++;
                    }
                    if (countDrinks >= 3)
                    {
                        drinks.Add("water");
                    }

                    Console.WriteLine(string.Join(", ", drinks));
                }
            }
        }
    }
}
