using System;

namespace Find_Maximum_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double sum = 0;
           
            double highest = double.MinValue;

            for (int i = 1; i <= N; i++)
            {
                double number = double.Parse(Console.ReadLine());

                sum += number;

               
                    if (number > highest)
                    {
                        highest = number;
                    }
                
            }
            
            Console.WriteLine($"{highest}");
        }
    }
}
