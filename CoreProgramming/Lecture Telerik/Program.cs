using System;

namespace Lecture_Telerik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //konvenciq za pisane na metodi e s Pascal Case - (PrintLogo()) , dokato primerno za promenlivite e Camel Case - (maxAge)
            //PrintInCapitalLetters("Hello"); // ako zadurjim mishkata se vijda, void,program,Print - kakvo vrushta(return type), v koi klas e i imeto na metoda, mojem da dobavim klas s primerno: Program.Print();
            //PrintInCapitalLetters("My");
            //PrintInCapitalLetters("name");
            //PrintInCapitalLetters("pesho");

            PrintRepeatedString("asd", 10);
        }

        //static void Print() //void - prosto shte printira i nqma da vrushta stoinost
        //{
        //    Console.WriteLine("Hello");
        //}

        static void PrintInCapitalLetters(string text) // sled kato sme podali parametri na metoda i v tozi sluchai e "string" - nqma kak da vuvedem po-gore neshto razlichno ot string
        {
            Console.WriteLine(text.ToUpper());
        }

        // statichna tipizaciq(static typing): oshte po vreme na kompilaciq, kompilatora proverqva dali dadenite data types sa validni i suotvetno - string - string - int - int i tn, proverqva za sintaksis i validation in general

        static void PrintRepeatedString(string text, int times)
        {
            string start = "";
            for (int i = 0; i < times; i++)
            {
                start += text;
            }

            Console.WriteLine(start);
        }

        // ctrl+shift+space - hotkeys to check what parameters can be accepted in the method for calling: for example: Print(); - whether is string or int or without parameters

        //Overloading and optional Parameters
        //There could be multiple methods with the same name, but they have to receive different number and/or types of parameters

        static void Main()
        {
            Print();
            Print("Telerik Academy passed as parameter");
        }

        static void Print()
        {
            Console.WriteLine("Telerik Academy");
        }

        static void Print(string message)
        {
            Console.Write(message);
        }

        //Optional Parameter

        static void Main()
        {
            Print();
            Print("Hello"); //This will print Hello
        }

        static void Print(string message = "Telerik Academy")
        {
            Console.WriteLine(message);
        }


        //Params - zaduljitelno parametrite sa ot 1 i sushti tip, zaduljitelno trqbva da e v kraq na signaturata ako podavame i drugi parametri

        static void Main()
        {
            Print(); // 1 variqnt // ako nqma dumata params --- Print (new string[0]);
            Print("asd"); // 2 variqnt // ako nqma dumata params --- Print (new string[] { "asd" });
            Print("ad", "asdasd", "asdasd"); // 3 variqnt i tn i tn
        }

        static void Print(params string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        // Return types

        // ako e void "return" terinira metoda i ne vrushta stoinost, no ako e drug tip, "return" e zaduljilteno za da vurne stoinost


        static void Main()
        {
            int nextNum = GetNumberFromConsole();
        }
        static int GetNumberFromConsole()
        {
            string numberAsText = Console.ReadLine();
            int number = int.Parse(numberAsText);
            return number;
        }

        //Or if you want to add 2 or more Return types


        static void Main()
        {
            (string name, int age) = GetNumberFromConsole();

            Console.WriteLine(name);
            Console.WriteLine(age);

        }
        static (string name, int age) GetNumberFromConsole()
        {
            return ("Gosho", 5);
        }

    }

}
