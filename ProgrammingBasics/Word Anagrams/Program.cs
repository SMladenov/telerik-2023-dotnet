using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 5 - Anagrama
            string w = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                bool isValid = true;

                if (w.Length != word.Length)
                {
                    Console.WriteLine("No");
                    continue;
                }

                if (w.Length == word.Length)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (!w.Contains(word[j]))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine("Yes");
                }
                else if (isValid == false)
                {
                    Console.WriteLine("No");
                }
            }

            ////zadacha 5 - Anagrama s List

            //string w = Console.ReadLine();
            //List<char> wordCharacters = w.ToCharArray().ToList();
            //wordCharacters.Sort();

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string word = Console.ReadLine();
            //    List<char> secondWordCharacters = word.ToCharArray().ToList();
            //    secondWordCharacters.Sort();

            //    // a b c d e 
            //    // a b c d e
            //    // a b c
            //    bool isValid = true;

            //    if (wordCharacters.Count != secondWordCharacters.Count)
            //    {
            //        Console.WriteLine("No");
            //        continue;
            //    }
            //    for (int j = 0; j < secondWordCharacters.Count; j++)
            //    {
            //        if (secondWordCharacters[j] != wordCharacters[j])
            //        {
            //            isValid = false;
            //        }

            //    }
            //    if (isValid)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
        }
        }
    }
}
