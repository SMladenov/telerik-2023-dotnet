using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeren_Izpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //int Oranges = 0;
            //int Apples = 0;

            //for (int i = 1; i <= n; i++)
            //{

            //    if (i % 2 == 0)
            //    {

            //        int fruitApples = i * i;
            //        Apples += fruitApples;
            //    }
            //    else
            //    {

            //        int fruitOranges = i * i;
            //        Oranges += fruitOranges;
            //    }

            //}

            //int difference = Apples - Oranges;

            //Console.WriteLine(difference);

            ////zadacha 1
            //string validWords = Console.ReadLine();
            //List<string> words = validWords.Split(',')
            //                     .ToList();

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    var plate = Console.ReadLine();

            //    if (plate.Length == 8)
            //    {
            //            if (words.Contains(plate[0].ToString()) && words.Contains(plate[1].ToString()) && words.Contains(plate[6].ToString()) 
            //            && words.Contains(plate[7].ToString())
            //                && char.IsUpper(plate[0]) && char.IsUpper(plate[1]) && char.IsUpper(plate[6]) && char.IsUpper(plate[7])
            //                && char.IsDigit(plate[2]) && char.IsDigit(plate[3]) && char.IsDigit(plate[4]) && char.IsDigit(plate[5]))
            //            {

            //            Console.WriteLine(plate);
            //            }
            //    }

            //}

            ////zadacha 2
            //string input;
            //int x = 0;
            //int y = 0;
            //int quadrant = 0;

            //while ((input = Console.ReadLine()) != "end")
            //{

            //    if (input == "L")
            //    {
            //        x--;
            //    }
            //    if (input == "R")
            //    {
            //        x++;
            //    }
            //    if (input == "D")
            //    {
            //        y--;
            //    }
            //    if (input == "U")
            //    {
            //        y++;
            //    }

            //}
            //if (x < 0 && y > 0)
            //{
            //    quadrant = 1;
            //}
            //if (x > 0 && y > 0)
            //{
            //    quadrant = 2;
            //}
            //if (y < 0 && x > 0)
            //{
            //    quadrant = 4;
            //}
            //if (y < 0 && x < 0)
            //{
            //    quadrant = 3;
            //}
            //if (x == 0 && y > 0)
            //{
            //    quadrant = 1;
            //}
            //if (x == 0 && y < 0)
            //{
            //    quadrant = 3;
            //}
            //if (y == 0 && x > 0)
            //{
            //    quadrant = 2;
            //}
            //if (y == 0 && x < 0)
            //{
            //    quadrant = 1;
            //}
            //Console.WriteLine(quadrant);

            ////Zadacha 3
            //int n = int.Parse(Console.ReadLine());

            //string row1 = "Q,W,E,R,T,Y,U,I,O,P";
            //string row2 = "A,S,D,F,G,H,J,K,L";
            //string row3 = "Z,X,C,V,B,N,M";

            //List<string> list1 = row1.Split(',')
            //                    .ToList();
            //List<string> list2 = row2.Split(',')
            //                    .ToList();
            //List<string> list3 = row3.Split(',')
            //                    .ToList();

            //for (int i = 1; i <= n; i++)
            //{
            //    string letters = Console.ReadLine();

            //    string currentRow = "";
            //    bool isValid = true;

            //    for (int j = 0; j < letters.Length; j++)
            //    {
            //        if (list1.Contains(letters[j].ToString(), StringComparer.OrdinalIgnoreCase))
            //        {
            //            if (currentRow == "")
            //            {
            //                currentRow = "1";
            //            }
            //            if (currentRow == "2" || currentRow == "3")
            //            {
            //                isValid = false;
            //                Console.WriteLine("Invalid input");
            //                break;
            //            }
            //        }
            //        if (list2.Contains(letters[j].ToString(), StringComparer.OrdinalIgnoreCase))
            //        {
            //            if (currentRow == "")
            //            {
            //                currentRow = "2";
            //            }
            //            if (currentRow == "1" || currentRow == "3")
            //            {
            //                isValid = false;
            //                Console.WriteLine("Invalid input");
            //                break;
            //            }
            //        }
            //        if (list3.Contains(letters[j].ToString(), StringComparer.OrdinalIgnoreCase))
            //        {
            //            if (currentRow == "")
            //            {
            //                currentRow = "3";
            //            }
            //            if (currentRow == "1" || currentRow == "2")
            //            {
            //                isValid = false;
            //                Console.WriteLine("Invalid input");
            //                break;
            //            }
            //        }
            //    }
            //    if (isValid)
            //    {
            //     Console.WriteLine(currentRow);
            //    }
            //}

            ////zadacha 4

            //int n = int.Parse(Console.ReadLine());

            //double totalAmount = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    double bill = double.Parse(Console.ReadLine());

            //    if (bill >= 100)
            //    {
            //        double discountedPrice = bill * 0.85d;
            //        totalAmount += discountedPrice;
            //    }
            //    else
            //    {
            //        totalAmount += bill;
            //    }
            //}
            //Console.WriteLine($"{totalAmount:f2}");
                       
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
                    listTitle.Remove(word[c]);
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
