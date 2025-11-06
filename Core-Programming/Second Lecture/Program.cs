using System;

namespace Second_Lecture
{

    //class definition
    internal class Program
    {

        //method definition
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            PrintLogo(); // calling the method
            Print();
            Print("Hello2");
            Print("Hello2Example");
            PrintRepeatedString("Pesho", 5);
            int avgAge = GetAge(5, 3);
            Console.WriteLine(avgAge);
            PrintOptional();
            PrintOptional("Not Optional");
            PrintOptional2(5);
            PrintOptional2(10, "test");
            PrintParams("asd");
            PrintParams("asd", "test", "test2");
            (string name, int age) = GetnumberFromConsole();
            Console.WriteLine($"{name} is {age} years old");

        }

        static void PrintLogo() // PrintLogo is the method's name
        {
            Console.WriteLine("Telerik Academy");
            Console.WriteLine("http://telerikacademy.com");
        }

        static void Print()
        {
            Console.WriteLine("Hello");
        }

        static void Print(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        static void PrintRepeatedString(string text, int times)
        {
            string start = "";
            for (int i = 0; i < times; i++)
            {
                start += text;
            }
            Console.WriteLine(start);
        }

        static int GetAge(int age1, int age2)
        {
            int avg = (age1 + age2) / 2;
            return avg;
        }

        // Optional parameter - must be at the end of the parameters of the method

        static void PrintOptional(string text = "Telerik Academy")
        {
            Console.WriteLine(text.ToUpper());
        }

        static void PrintOptional2(int times, string text = "Telerik")
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        // Params - they must on the same value type ( e.g. string string string, int int and etc ) // Given a massive of strings in th example below
        // Also Params must be at the end of the parameters / arguments of the method
        // Spestqva ni ot zaduljitelnoto pisane na masivi v main method-a pri vikane na Params method

        static void PrintParams(params string[] args)
        {
            foreach (var arg in args)
            {
                Console.Write($"{arg}, ");
            }
            Console.WriteLine();
        }

        // Tuple

        static (string name, int age) GetnumberFromConsole()
        {
            return ("Gosho", 5);
        }
        
    }
}
