
using System;

namespace Chalenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "git is a <<version control>> for tracking changes in <<computer files>> and coordinating work";


            while (input.Contains("<<"))
            {
                int startIndex = input.IndexOf("<<") + 2;
                int endIndex = input.IndexOf(">>");
                string content = input.Substring(startIndex, endIndex - startIndex);
                input = input.Replace("<<" + content + ">>", content.ToUpper());
            }
                Console.WriteLine(input);
        }
    }
}
