using System;

namespace Calculate_Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double N = double.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= N; i++)
            {

                double itemPrice = double.Parse(Console.ReadLine());

                double discountedPrice = itemPrice * 0.35d;

                //result = "";
                //"10"

                string numberAsString = $"{discountedPrice:f2}".ToString();

                result = result + $"{discountedPrice:F2}" + Environment.NewLine;

                //=> "" discountedPrice.ToString() => go to next line
                //  result = "" + "10.00"

                //=> "10.00" + "20.00
                //  result = "10.0020.00

                //Console.WriteLine($"{discountedPrice:F2}");

            }

            Console.WriteLine(result);

        }
    }
}
