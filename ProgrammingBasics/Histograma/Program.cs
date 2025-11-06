using System;

namespace Histograma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            // procentno razdelenie po grupi
           
            //broq chisla po grupi
            double countP1 = 0;
            double countP2 = 0;
            double countP3 = 0;
            double countP4 = 0;
            double countP5 = 0;


            for (int i = 1; i <= n; i++)
            {
                double numbers = int.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    countP1++;
                }
                if (numbers >= 200 && numbers < 400)
                {
                    countP2++;
                }
                if (numbers >= 400 && numbers < 600)
                {
                    countP3++;
                }
                if (numbers >= 600 && numbers < 800)
                {
                    countP4++;
                }
                if (numbers >= 800)
                {
                    countP5++;
                }

            }

            // umojavame po 100.0 za da ne se poluchi celochisleo delenie, a iskame drobno i s preciznost
            double p1Percentage = countP1 * 100.0 / n;
            double p2Percentage = countP2 * 100.0 / n;
            double p3Percentage = countP3 * 100.0 / n;
            double p4Percentage = countP4 * 100.0 / n;
            double p5Percentage = countP5 * 100.0 / n;

            Console.WriteLine($"{p1Percentage:f2}");
            Console.WriteLine($"{p2Percentage:f2}");
            Console.WriteLine($"{p3Percentage:f2}");
            Console.WriteLine($"{p4Percentage:f2}");
            Console.WriteLine($"{p5Percentage:f2}");





        }
    }
}
