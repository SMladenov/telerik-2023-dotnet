using System;

namespace Longest_String_Telerik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string meal;
            //string result = "";

            //while (true)
            //{
            //    meal = Console.ReadLine();

            //    if (meal == "END")
            //    {
            //        Console.WriteLine(result);
            //        return;

            //    }

            //    if (meal.Length >= result.Length)
            //    {
            //        result = meal;
            //    }

            //}


            //string meal;
            //string result = "";

            //while ((meal = Console.ReadLine()) != "END")
            //{

            //    if (meal.Length >= result.Length)
            //    {
            //        result = meal;
            //    }

            //}
            //Console.WriteLine(result);

            // zadacha: 3 stringa na 3 inpuita, 3 imena, celta e da printna 2 imena bez 2-roto

            string meal;
            string result = null;

            do
            {
                meal = Console.ReadLine();

                if (meal.Length >= result.Length && meal != "END")
                {
                    result = meal;
                }

            } while (meal != "END");

            Console.Write(result);


        }
    }
}
