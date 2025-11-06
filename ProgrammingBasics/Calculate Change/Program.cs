using System;

namespace Calculate_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double price = double.Parse(Console.ReadLine());
            double pay = double.Parse(Console.ReadLine());

            double change = pay - price;

            double changeStotinki = change * 100;
            double stotinki50 = changeStotinki % 100;
            double stotinki20 = stotinki50 % 50;
            double stotinki10 = stotinki20 % 20;
            double stotinki5 = stotinki10 % 10;
            double stotinki2 = stotinki5 % 5;
            double stotinki1 = stotinki2 % 2;

            double ChangeLev = changeStotinki / 100;
            double wholenumber = Math.Floor(ChangeLev);
            if (wholenumber >= 1)
            {
                Console.WriteLine($"{wholenumber} x 1 lev");
            }

            double stotinki502 = stotinki50 / 50;
            double wholenumber2 = Math.Floor(stotinki502);
            if (wholenumber2 >= 1)
            {
                Console.WriteLine($"{wholenumber2} x 50 stotinki");
            }

            double stotinki202 = stotinki20 / 20;
            double wholenumber3 = Math.Floor(stotinki202);
            if (wholenumber3 >= 1)
            {
                Console.WriteLine($"{wholenumber3} x 20 stotinki");
            }

            double stotinki102 = stotinki10 / 10;
            double wholenumber4 = Math.Floor(stotinki102);
            if (wholenumber4 >= 1)
            {
                Console.WriteLine($"{wholenumber4} x 10 stotinki");
            }

            double stotinki52 = stotinki5 / 5;
            double wholenumber5 = Math.Floor(stotinki52);
            if (wholenumber5 >= 1)
            {
                Console.WriteLine($"{wholenumber5} x 5 stotinki");
            }

            double stotinki22 = stotinki2 / 2;
            double wholenumber6 = Math.Floor(stotinki22);
            if (wholenumber6 >= 1)
            {
                Console.WriteLine($"{wholenumber6} x 2 stotinki");
            }

            double stotinki12 = stotinki1 / 1;
            double wholenumber7 = Math.Floor(stotinki12);
            if (wholenumber7 >= 1)
            {
                Console.WriteLine($"{wholenumber7} x 1 stotinka");
            }

        }
    }
}
