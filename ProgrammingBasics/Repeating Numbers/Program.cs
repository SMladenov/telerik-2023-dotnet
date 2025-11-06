using System;
using System.Linq;

namespace Repeating_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // 0 1 2 3 4 5 6 7 8 9 10
            // 0 0 0 0 0 0 0 0 0 0 0 
            int[] arr = new int[11];

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                arr[current]++;
            }

            int maxNumber = arr.Max();
            int maxIndex = arr.ToList().IndexOf(maxNumber);

            Console.WriteLine(maxIndex);
        }
    }
}
