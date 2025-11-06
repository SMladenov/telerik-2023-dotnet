using System;

namespace stringTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string names = Console.ReadLine();

            //string[] subStrings = names.Split(' ');
            //string finalNames = subStrings[2] + " " + subStrings[1] + " " + subStrings[0];
            //Console.WriteLine(finalNames);

            string names;

            while ((names = Console.ReadLine()) != "n")
            {
                
                string[] subStrings = names.Split(' ');
                string finalNames = subStrings[2] + " " + subStrings[0];
                Console.WriteLine(finalNames);

            }


            //string names = Console.ReadLine();
            //string[] subStrings = names.Split(' ');
            //string finalNames = subStrings[2] + " " + subStrings[0];
            //Console.WriteLine(finalNames);




        }
    }
}
