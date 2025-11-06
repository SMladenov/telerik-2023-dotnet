using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("audi");
            
            var boat = new Boat();
            boat.Make = "Maicubashi";
            var vehicles = new List<IVehicle>();
            vehicles.Add(boat);
            vehicles.Add(car);

            foreach (var item in vehicles)
            {
                item.GetVehicleType();
                Console.WriteLine(item.Make);
            }



            string input1 = Console.ReadLine();
            List<int> numbers = input1.Split(' ')
                            .Select(x => int.Parse(x))
                            .ToList();

            int maxNumber = int.MinValue;

            bool ascending = true;
            bool descending = true;
            //bool mixed = true;

            for(int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] > numbers[i+1])
                {
                    ascending = false;
                }
                else if(numbers[i] < numbers[i+1])
                {
                    descending = false;
                }
            }


            //for (int i = 0; i < numbers.Count - 1; i++)
            //{
            //    if (Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[i + 1]))
            //    {
            //        if (Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[2]) ||
            //            Convert.ToInt32(numbers[2]) > Convert.ToInt32(numbers[3]) ||
            //            (Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[3])))

            //        {
            //            mixed = true;
            //            ascending = false;
            //            descending = false;
            //            break;
            //        }
            //    }
            //    if (Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[i + 1]))
            //    {
            //        if (Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[2]) ||
            //            Convert.ToInt32(numbers[2]) < Convert.ToInt32(numbers[3]) ||
            //            (Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[3])))
            //        {
            //            mixed = true;
            //            ascending = false;
            //            descending = false;
            //            break;
            //        }
            //    }
            //    if (Convert.ToInt32(numbers[i]) == Convert.ToInt32(numbers[i + 1]))
            //    {
            //        mixed = true;
            //        ascending = false;
            //        descending = false;
            //        break;
            //    }
            //    else if (Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[i + 1]))
            //    {
            //        ascending = true;
            //        mixed = false;
            //        descending = false;
            //    }
            //    else if (Convert.ToInt32(numbers[i]) > Convert.ToInt32(numbers[i + 1]))
            //    {
            //        descending = true;
            //        ascending = false;
            //        mixed = false;
            //    }


            //}
            //if (ascending)
            //{
            //    Console.WriteLine("Ascending");
            //}
            //if (descending)
            //{
            //    Console.WriteLine("Descending");
            //}
            //if (mixed)
            //{
            //    Console.WriteLine("Mixed");
            //}


        }

    }
}
