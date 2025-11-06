using System;

namespace Guess_the_Season
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());

            bool spring = (month == "March" && day >= 20 && day <= 31) || (month == "April" || month == "May" && day <= 31) ||
                (month == "June" && day <= 20);

            bool summer = (month == "June" && day > 20 && day <= 31) || (month == "July" || month == "August" && day <= 31) ||
                (month == "September" && day <= 21);

            bool autumn = (month == "September" && day > 21 && day <= 31) || (month == "October" || month == "November" && day <= 31) ||
                (month == "December" && day <= 20);

            bool winter = (month == "December" && day > 20 && day <= 31) || (month == "January" || month == "February" && day <= 31) ||
                (month == "March" && day <= 19);

            if (spring)
            {
                Console.WriteLine("Spring");
            }
            else if (summer)
            {
                Console.WriteLine("Summer");
            }
            else if (autumn)
            {
                Console.WriteLine("Autumn");
            }
            else if (winter)
            {
                Console.WriteLine("Winter");
            }

        }
    }
}
