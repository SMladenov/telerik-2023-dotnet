using System;

namespace Multiplication_sign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var N = (Console.ReadLine());


            //double N2;
            //bool isNumber = double.TryParse(N, out N2);

            //bool range = N2 <= 0 && N2 <= 9;

            //if (isNumber)
            //{
            //    if (N2 == 0)
            //    {
            //        Console.WriteLine("zero");
            //    }
            //    else if (N2 == 1)
            //    {
            //        Console.WriteLine("one");
            //    }
            //    else if (N2 == 2)
            //    {
            //        Console.WriteLine("two");
            //    }
            //    else if (N2 == 3)
            //    {
            //        Console.WriteLine("three");
            //    }
            //    else if (N2 == 4)
            //    {
            //        Console.WriteLine("four");
            //    }
            //    else if (N2 == 5)
            //    {
            //        Console.WriteLine("five");
            //    }
            //    else if (N2 == 6)
            //    {
            //        Console.WriteLine("six");
            //    }
            //    else if (N2 == 7)
            //    {
            //        Console.WriteLine("seven");
            //    }
            //    else if (N2 == 8)
            //    {
            //        Console.WriteLine("eight");
            //    }
            //    else if (N2 == 9)
            //    {
            //        Console.WriteLine("nine");
            //    }
            //    else if (range == false)
            //    {
            //        Console.WriteLine("not a digit");
            //    }
            //}


            var value = Console.ReadLine();

            int number;
            bool isNumber = int.TryParse(value, out number);


            bool isInRange = number >= 0 && number <= 9;

            switch (isNumber && isInRange)
            {
                case true:
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine("zero");
                            break;
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }

            //int digit;
            //digit = Convert.ToInt32(Console.ReadLine());

            //switch (digit)
            //{
            //    case 0:
            //        Console.WriteLine("zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("one");
            //        break;
            //    case 2:
            //        Console.WriteLine("two");
            //        break;
            //    case 3:
            //        Console.WriteLine("three");
            //        break;
            //    case 4:
            //        Console.WriteLine("four");
            //        break;
            //    case 5:
            //        Console.WriteLine("five");
            //        break;
            //    case 6:
            //        Console.WriteLine("six");
            //        break;
            //    case 7:
            //        Console.WriteLine("seven");
            //        break;
            //    case 8:
            //        Console.WriteLine("eight");
            //        break;
            //    case 9:
            //        Console.WriteLine("nine");
            //        break;
            //    default:
            //        Console.WriteLine("is not a digit");
            //        break;
            //}


        }
    }
}
