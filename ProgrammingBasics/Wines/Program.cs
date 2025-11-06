using System;

namespace Wines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colleaguesCount = int.Parse(Console.ReadLine());

            var M = int.Parse(Console.ReadLine());

            var vineyard = Console.ReadLine();

            var mililitersOfWineRequired = 2 * 150.0 * colleaguesCount;
            var bottlesWineRequired = Math.Ceiling(mililitersOfWineRequired / 750);

            var mililitersOfRakiaRequired = 50.0 * colleaguesCount;
            var bottlesRakiaRequired = Math.Ceiling(mililitersOfRakiaRequired / 700);

            var avgQualityGrape = 0;
            var perfectQualityGrape = 0;

            for (int i = 0; i < M; i++)
            {
                if (vineyard[i] == 'x')
                {
                    avgQualityGrape += 7;
                }
                if (vineyard[i] == 'X')
                {
                    perfectQualityGrape += 7;
                }
            }

            var bottlesWineProduced = perfectQualityGrape;
            var bottlesRakiaProduced = Math.Floor(avgQualityGrape / 5.0);

            if (bottlesWineRequired > bottlesWineProduced || bottlesRakiaRequired > bottlesRakiaProduced)
            {
                double rakia;
                if (bottlesRakiaRequired - bottlesRakiaProduced < 0)
                {
                    rakia = 0;
                }
                else
                {
                    rakia = bottlesRakiaRequired - bottlesRakiaProduced;
                }

                double wine;
                if (bottlesWineRequired - bottlesWineProduced < 0)
                {
                    wine = 0;
                }
                else
                {
                    wine = bottlesWineRequired - bottlesWineProduced;
                }
                Console.WriteLine($"No! {wine} more bottles of wine and {rakia} more bottles of rakia required!");
            }
            if (bottlesWineRequired <= bottlesWineProduced && bottlesRakiaRequired <= bottlesRakiaProduced)
            {
                Console.WriteLine($"Yes! {bottlesWineProduced - bottlesWineRequired} of wine and {bottlesRakiaProduced - bottlesRakiaRequired} bottles of rakia remaining for the next party!");
            }
        }
    }
}
