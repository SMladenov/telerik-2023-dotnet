using System;

namespace Time_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int yearsToCalculate = year - 1800;

            double moneyNeededForEvenYear = 0;
            double moneyNeededForOddYear = 0;
            int MoneyForYear = 12000;

            for (int i = 0; i <= yearsToCalculate; i++)
            {
                int age = 18 + i;
                if (i % 2 == 0)
                {
                    moneyNeededForEvenYear += 12000;
                }
                if (i % 2 == 1)
                {
                    int calculatingOddYear = MoneyForYear + 50 * age;
                    moneyNeededForOddYear += calculatingOddYear;
                }

            }

            double allMoneyNeeded = moneyNeededForEvenYear + moneyNeededForOddYear;

            if (money > allMoneyNeeded)
            {
                double difference = Math.Abs(money - allMoneyNeeded);
                Console.WriteLine($"He will live and will have {difference:f2} amount left");
            }
            if (money < allMoneyNeeded)
            {
                double difference2 = Math.Abs(money - allMoneyNeeded);
                Console.WriteLine($"He won't have enough money to live, he will need {difference2:f2} more");
            }

        }
    }
}
