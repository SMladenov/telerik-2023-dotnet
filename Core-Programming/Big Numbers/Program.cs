using System;
using System.Collections.Generic;
using System.Linq;

namespace Big_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int digit1 = int.Parse(input.Split(' ')[0]);
            int digit2 = int.Parse(input.Split(' ')[1]);
       
            int[] longer = new int[0];
            int[] shorter = new int[0];
            if (digit1 > digit2)
            {
                longer = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                shorter = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            else
            {
                shorter = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                longer = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            List<int> list = new List<int>();

            bool remainder = false;

            for (int i = 0; i < longer.Length; i++)
            {
                if (i < shorter.Length)
                {
                    var sum = remainder ?
                        longer[i] + shorter[i] + 1 :
                        longer[i] + shorter[i];

                    if (sum >= 10)
                    {
                        int sum2 = sum % 10;
                        list.Add(sum2);
                        remainder = true;
                    }
                    else
                    {
                        list.Add(sum);
                        remainder = false;
                    }

                }
                else
                {

                    var sum = remainder ?
                    longer[i] + 1 :
                    longer[i];

                    if (sum >= 10)
                    {
                        int sum2 = sum % 10;
                        list.Add(sum2);
                        remainder = true;
                    }
                    else
                    {
                        list.Add(sum);
                        remainder = false;
                    }

                }

            }
            if (remainder)
            {
                list.Add(1);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
