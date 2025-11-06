using System;
using System.Collections.Generic;

namespace Most_Frequent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            //int[] arr = new int[10000];

            //int mostOccurence = 0;
            //int mostOccured = 0;

            //foreach (var i in list)
            //{
            //    arr[i] = arr[i] + 1;
            //    if (mostOccurence < arr[i])
            //    {
            //        mostOccurence = arr[i];
            //        mostOccured = i;
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]}, ");
            //}

            var maxAcc = 0;
            var result = 0;

            for (int i = 0; i < list.Count-1; i++)
            {
                var currentNumber = list[i];
                var counter = 1;
                if(list[i] == 0)
                {
                    continue;
                }
                for (int y = i + 1; y < list.Count; y++)
                {
                    //4 4 1 2 3 4 1 2 2 4 4 4
                    if(currentNumber == list[y])
                    {
                        counter++;
                        list[y] = 0;
                    }
                    if(counter > maxAcc)
                    {
                        maxAcc = counter;
                        result = currentNumber;
                    }

                }
                counter = 0;
            }


            //for (int i = 0; i < list.Count; i++)
            //{
            //    int tempOccurance = 1;
            //    for (int j = i + 1; j < list.Count - 1; j++)
            //    {
            //        if (list[i] == list[j])
            //        {
            //            tempOccurance++;
            //        }
            //    }
            //    if (tempOccurance > mostOccurence)
            //    {
            //        mostOccurence = tempOccurance;
            //        mostOccured = list[i];
            //    }

            //}

            Console.WriteLine($"{result} ({maxAcc} times)");



        }
    }
}
