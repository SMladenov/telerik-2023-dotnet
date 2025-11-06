using System;
using System.Collections.Generic;
using System.Linq;

namespace Check_for_Play_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string validCards = "2,3,4,5,6,7,8,9,10,J,Q,K,A";

            List<string> cards = validCards.Split(',').ToList();

            if (cards.Contains(input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }








        }
    }
}
