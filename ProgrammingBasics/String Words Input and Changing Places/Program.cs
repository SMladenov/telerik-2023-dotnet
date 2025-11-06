using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Words_Input_and_Changing_Places
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string names = Console.ReadLine();
                string[] subString = names.Split(' ');
                string finalNames = subString[2] + " " + subString[0];
                list.Add(finalNames);
            }

            Console.WriteLine(string.Join((Environment.NewLine), list));


        }
    }
}
