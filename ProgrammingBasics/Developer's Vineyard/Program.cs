using System;

namespace Developer_s_Vineyard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colleagues = int.Parse(Console.ReadLine());

            int vineyard = int.Parse(Console.ReadLine());

            

            string quality = Console.ReadLine();

            int perfectQuality = 0;
            int averageQuality = 0;
            for (int i = 0; i < quality.Length; i++)
            {
                if (quality[i] == 'X')
                {
                    perfectQuality++;
                }
                if (quality[i] == 'x')
                {
                    averageQuality++;
                }
            }

            int kilosPerfect = perfectQuality * 7;
            int kilosAverage = averageQuality * 7;

            int bottleWine = kilosPerfect;
            int bottleRakia = kilosAverage / 5;

            int totalGlassesWine = bottleWine * 5;
            int totalGlassesRakia = bottleRakia * 14;

            int requiredGlassesWine = colleagues * 2;
            int requiredGlassesRakia = colleagues;


            if (totalGlassesWine >= requiredGlassesWine && totalGlassesRakia >= requiredGlassesRakia)
            {
                int remainingWine = (totalGlassesWine - requiredGlassesWine) / 5;
                int remainingRakia = (totalGlassesRakia - requiredGlassesRakia) / 14;
                Console.WriteLine($"Yes! {remainingWine} bottles of wine and {remainingRakia} bottles of rakia remaining for the next party!");
            }

            if (totalGlassesWine < requiredGlassesWine || totalGlassesRakia < requiredGlassesRakia)
            {
                int requiredWineBottles = (requiredGlassesWine - totalGlassesWine) / 5;
                int extraWine = (requiredGlassesWine - totalGlassesWine) % 5;

                int requiredRakiaBottles = (requiredGlassesRakia - totalGlassesRakia) / 14;
                int extraRakia = (requiredGlassesRakia - totalGlassesRakia) % 14;
                if (requiredWineBottles < 0)
                {
                    requiredWineBottles = 0;
                }
                if (requiredRakiaBottles < 0)
                {
                    requiredRakiaBottles = 0;
                }
                if (extraWine > 0)
                {
                    requiredWineBottles++;
                }
                if (extraRakia > 0)
                {
                    requiredRakiaBottles++;
                }

                Console.WriteLine($"No! {requiredWineBottles} more bottles of wine and {requiredRakiaBottles} more bottles of rakia required!");
            }
            //if ((requiredGlassesWine > totalGlassesWine) && (requiredGlassesRakia > totalGlassesRakia))
            //{
            //    long differenceWine = Math.Abs(requiredGlassesWine - totalGlassesWine);
            //    long differenceRakia = Math.Abs(requiredGlassesRakia - totalGlassesRakia);
            //    long notBottleWine = differenceWine / 5;
            //    long notBottleRakia = 0;
            //    if (differenceRakia > 14)
            //    {
            //        notBottleRakia = differenceRakia / 14;
            //    }
            //    else if (differenceRakia < 14)
            //    {
            //        notBottleRakia = 1;
            //    }
            //        Console.WriteLine($"No! {notBottleWine} more bottles of wine and {notBottleRakia} more bottles of rakia required!");

            //}
            //if ((requiredGlassesWine > totalGlassesWine) && (requiredGlassesRakia < totalGlassesRakia))
            //{
            //    long differenceWine = Math.Abs(requiredGlassesWine - totalGlassesWine);
            //    long notBottleWine = differenceWine / 5;
            //    long notBottleRakia = 0;

            //    Console.WriteLine($"No! {notBottleWine} more bottles of wine and {notBottleRakia} more bottles of rakia required!");
            //}
            //if ((requiredGlassesWine < totalGlassesWine) && (requiredGlassesRakia > totalGlassesRakia))
            //{
            //    //int differenceWine = Math.Abs(requiredGlassesWine - totalGlassesWine);
            //    long differenceRakia = Math.Abs(requiredGlassesRakia - totalGlassesRakia);
            //    long notBottleWine = 0;
            //    long notBottleRakia = 0;
            //    if (differenceRakia > 14)
            //    {
            //        notBottleRakia = differenceRakia / 14;
            //    }
            //    else if (differenceRakia < 14)
            //    {
            //        notBottleRakia = 1;
            //    }
            //    Console.WriteLine($"No! {notBottleWine} more bottles of wine and {notBottleRakia} more bottles of rakia required!");
            //}
            //if ((requiredGlassesWine < totalGlassesWine) && (requiredGlassesRakia < totalGlassesRakia))
            //{
            //    long differenceWine = Math.Abs(totalGlassesWine - requiredGlassesWine);
            //    long differenceRakia = Math.Abs(totalGlassesRakia - requiredGlassesRakia);
            //    long notBottleWine = differenceWine / 5;
            //    long notBottleRakia = 0;
            //    if (differenceRakia > 14)
            //    {
            //        notBottleRakia = differenceRakia / 14;
            //    }
            //    else if (differenceRakia < 14)
            //    {
            //        notBottleRakia = 1;
            //    }
            //    Console.WriteLine($"Yes! {notBottleWine} bottles of wine and {notBottleRakia} bottles of rakia remaining for the next party!");
            //}
        }
    }
}
