using System;
using System.Collections.Generic;

namespace Title_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title search
            string title = Console.ReadLine().ToLower();
            List<char> listTitle = new List<char>();
            for (int i = 0; i < title.Length; i++)
            {
                listTitle.Add(title[i]);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                var tempList = new List<char>(listTitle);
                var isValid = true;
                var currentInedxOf = 0;
                var secondCurrentIndexOf = 0;

                for (int z = 0; z < word.Length; z++)
                {
                    currentInedxOf = listTitle.IndexOf(word[z], currentInedxOf);

                    if (currentInedxOf != -1)
                    {
                        tempList.Remove(word[z]);
                    }
                    else
                    {
                        Console.WriteLine("No such title found!");
                        isValid = false;
                        break;
                    }
                }
                if (!isValid)
                {
                    continue;
                }

                for (int c = 0; c < word.Length; c++)
                {
                    secondCurrentIndexOf = listTitle.IndexOf(word[c], secondCurrentIndexOf);
                    listTitle.RemoveAt(secondCurrentIndexOf);
                }

                for (int d = 0; d < listTitle.Count; d++)
                {

                    Console.Write(listTitle[d]);
                }
                Console.WriteLine();
            }
        }
    }
}
