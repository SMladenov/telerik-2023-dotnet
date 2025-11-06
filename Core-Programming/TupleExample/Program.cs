using System;

namespace TupleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            (int, int, int) myTuple = (firstNumber, secondNumber, thirdNumber);

            int sum = myTuple.Item1 + myTuple.Item2 + myTuple.Item3;

            Console.WriteLine(sum);

        }

        static Tuple<int, int> CalculateSmth(Tuple<int, int, int> myTuple)
        {



        }
    }
}
