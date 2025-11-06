using System;

namespace Circle_Perimeter_and_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {

             //Area = Math.PI * r * r
             //Perimeter = 2 * Math.PI * r



            int r = int.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"{perimeter:f2}");

            Console.WriteLine($"{area:f2}");

            double r2 = double.Parse(Console.ReadLine());

            double area2 = Math.PI * r2 * r2;

            double perimeter2 = 2 * Math.PI * r2;

            Console.WriteLine($"{perimeter2:f2}");

            Console.WriteLine($"{area2:f2}");


        }
    }
}
