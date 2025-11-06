using System;

namespace Methods_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method-a e edno parche kod, koeto se izpulnqva kogato go izvikame, izpolzva se za izbqgvane na povtarqemost na koda i za po-lesna poddrujka sled tova

            string message = Console.ReadLine();
            PrintMessage();
            PrintMessage();
            PrintMessage(message);

            int result = Sum(2, 5);
            int result2 = Sum(2, 3, 4);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            int result = Sum(2, Sum(3, 4));
            Console.WriteLine(result);

            int[] array = { 1, 2, 3 }; //Tui kato e referenten tip masiv-a, dannite se prezapisvat v reda na povikvane
            ArrayMethod(array);

            array[0] = 1; //Vrushtame gi ako iskame
            array[1] = 2;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);

            Console.WriteLine(Sum());
            Console.WriteLine(Sum(2, 3, 5));
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello2");
            Console.WriteLine("Hello3");
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int Sum(int a, int b, int c)
        {
            //int result = a + b + c;
            int result = Sum(Sum(a, b), c);
            return result;
        }

        //calling Method as a parameter value
        static int Sum(int a, int b, int c = 0)
        {
            int result = a + b + c;
            return result;
        }

        static void ArrayMethod(int[] array)
        {
            array[0] = 5;
            array[1] = 6;
        }

        //Params - pozvolqva da mu zadavash neopredelen broi argumenti ( masiv ), ako ima drugi parametri, Params trqbva da e nai-otzad

        static int Sum(params int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return result;  
        }
    }
}
