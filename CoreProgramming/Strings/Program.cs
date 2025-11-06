using System;
using System.Diagnostics;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text4 = new string('=', 20);

            Console.WriteLine($"{text4}");

            //Ways to Contact String
            string a = "some";
            string b = "text";
            string result = a + " " + b;
            Console.WriteLine(result);
            string result2 = String.Concat(a, " ", b);
            Console.WriteLine(result2);
            Console.WriteLine($"{a} {b}");
            string result3 = String.Format("{0} {1}", a, b); //Place Holder
            Console.WriteLine(result3);

            string str2 = "text";
            string str3 = str2.Remove(2,1);
            string str4 = str2.Substring(1,3);
            Console.WriteLine($"Remove: {str3} and SubString: {str4}");

            //Ways with String Builder
            //Too low performance way as below and comparison:
            Stopwatch sw = new Stopwatch();
            string str1 = "a";
            sw.Start();
            for (int i = 0; i < 50000; i++)
            {
                str1 += "a";
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            StringBuilder stringBuilder = new StringBuilder();
            sw.Restart();

            for (int i = 0; i < 50000; i++)
            {
                stringBuilder.Append("a");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);


        }

        //static string PrintErrorMessage(string name)
        //{
        //    string result = String.Format("User {0} has entered invalid input");
        //    result = $"User {name} has entered invalid input";
        //    return result;
        //}
    }
}
