using System;

namespace Print_Deck_Of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cardSign = Console.ReadLine();

            var suit1 = "clubs";
            var suit2 = "diamonds";
            var suit3 = "hearts";
            var suit4 = "spades";

            
            if (cardSign == "2" || cardSign == "3" || cardSign == "4" || cardSign == "5" || cardSign == "6" || cardSign == "7" || cardSign == "8" || cardSign == "9" || cardSign == "10")


            {
                int cardSignInt = Int32.Parse(cardSign);
                for (int i = 2; i <= cardSignInt; i++)
                {

                    Console.WriteLine($"{i} of {suit4}, {i} of {suit1}, {i} of {suit3}, {i} of {suit2}");

                }

            }

            else if (cardSign == "J")
            {
                for (int b = 2; b <= 10; b++)
                {
                    Console.WriteLine($"{b} of {suit4}, {b} of {suit1}, {b} of {suit3}, {b} of {suit2}");
                }
                Console.WriteLine($"{cardSign} of {suit4}, {cardSign} of {suit1}, {cardSign} of {suit3}, {cardSign} of {suit2}");
            }

            else if (cardSign == "Q")
            {
                for (int c = 2; c <= 10; c++)
                {
                    Console.WriteLine($"{c} of {suit4}, {c} of {suit1}, {c} of {suit3}, {c} of {suit2}");
                }
                Console.WriteLine($"J of {suit4}, J of {suit1}, J of {suit3}, J of {suit2}");
                Console.WriteLine($"{cardSign} of {suit4}, {cardSign} of {suit1}, {cardSign} of {suit3}, {cardSign} of {suit2}");
            }

            else if (cardSign == "K")
            {
                for (int d = 2; d <= 10; d++)
                {
                    Console.WriteLine($"{d} of {suit4}, {d} of {suit1}, {d} of {suit3}, {d} of {suit2}");
                }
                Console.WriteLine($"J of {suit4}, J of {suit1}, J of {suit3}, J of {suit2}");
                Console.WriteLine($"Q of {suit4}, Q of {suit1}, Q of {suit3}, Q of {suit2}");
                Console.WriteLine($"{cardSign} of {suit4}, {cardSign} of {suit1}, {cardSign} of {suit3}, {cardSign} of {suit2}");
            }
            
            else if (cardSign == "A")
            {
                for (int e = 2; e <= 10; e++)
                {
                    Console.WriteLine($"{e} of {suit4}, {e} of {suit1}, {e} of {suit3}, {e} of {suit2}");
                }
                Console.WriteLine($"J of {suit4}, J of {suit1}, J of {suit3}, J of {suit2}");
                Console.WriteLine($"Q of {suit4}, Q of {suit1}, Q of {suit3}, Q of {suit2}");
                Console.WriteLine($"K of {suit4}, K of {suit1}, K of {suit3}, K of {suit2}");
                Console.WriteLine($"{cardSign} of {suit4}, {cardSign} of {suit1}, {cardSign} of {suit3}, {cardSign} of {suit2}");
            }
        }
    }
}
