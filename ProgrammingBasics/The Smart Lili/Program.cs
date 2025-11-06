using System;

namespace The_Smart_Lili
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int liliAge = int.Parse(Console.ReadLine());
            double liliWashingMachine = double.Parse(Console.ReadLine());
            double liliToy = int.Parse(Console.ReadLine());

            double totalAmountToy = 0;
            double totalAmountLeva = 0;
            double moneyForBirthday = 10;


            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 == 0)
                {
                    totalAmountLeva += (moneyForBirthday - 1);
                    moneyForBirthday += 10;
                }
                if (i % 2 == 1)
                {
                    totalAmountToy++;
                }
            }

            double toyLeva = totalAmountToy * liliToy;
            double totalAmountSaved = totalAmountLeva + toyLeva;

            if (totalAmountSaved > liliWashingMachine)
            {
                double difference = Math.Abs(totalAmountSaved - liliWashingMachine);
                Console.WriteLine($"Yes, you have {difference:f2} more");
            }
            if (totalAmountSaved == liliWashingMachine)
            {
                Console.WriteLine("Yes, you can afford it without any money left");
            }
            else if (liliWashingMachine > totalAmountSaved)
            {
                double difference2 = Math.Abs(liliWashingMachine - totalAmountSaved);
                Console.WriteLine($"No, you are {difference2:f2} leva short");
            }

        }
    }
}
