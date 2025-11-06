using System;

namespace Dog_Years
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int HY = int.Parse(Console.ReadLine());

            if (HY <= 2)
            {
                int DY1 = HY * 10;
                Console.WriteLine(DY1);
            }
            else 
            {
                int DY2 = HY - 2;
                int DY3 = DY2 * 4;
                int total = DY3 + 20;
                Console.WriteLine(total);
            }

            //            int HY = int.Parse(Console.ReadLine());

            //            int DY1 = HY * 10;
            //            int DY2 = (((DY1 / 10) - 2) * 4) + 20;

            //            if (HY <= 2)
            //            {
            //                Console.WriteLine(DY1);
            //            }
            //            else
            //            {
            //                Console.WriteLine(DY2);
            //            }

        }
    }
}
