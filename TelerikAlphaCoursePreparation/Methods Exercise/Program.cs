using System;
using System.Collections.Generic;

namespace Methods_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<string> names = new List<string>() { "Pesho", "Gosho", "Niki" };
            //for (int i = 0; i < names.Count; i++)
            //{
            //    Print(names[i]);
            //}
            double gradeOne = double.Parse(Console.ReadLine());
            double gradeTwo = double.Parse(Console.ReadLine());


            double averageGrade = CalculateAverageGrades(gradeOne, gradeTwo);

            Print(averageGrade.ToString());

            //int mathGrade = 5;
            //int englGrade = 3;

            //ModifyGrade(mathGrade); // copy of value type
            //ModifyGrade(englGrade);

            //Console.WriteLine(mathGrade);
            //Console.WriteLine(englGrade);

            //ModifyList(names); // pass the reference of refference type

            //Console.WriteLine(string.Join(string.Empty, names));
        }

        static void ModifyGrade(int grade)
        {
            grade *= grade * 2;
        }

        // \u123ddqwe 
        static void ModifyList(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = "Batman";

            }
        }

        static void Print(string message, string optional = "Batman2")
        {
            Console.Write($"{message} ");
        }

        static double CalculateAverageGrades(double grade1, double grade2)
        {
            double avgGrade = (grade1 + grade2) / 2d;
            return avgGrade;
        }
    }
}
