using System;

namespace Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());

            double interest = 0.05d;

            double totalAmountInterest1 = n * interest;
            double totalAmountDeposit1 = n + totalAmountInterest1;

            double totalAmountInterest2 = totalAmountDeposit1 * interest;
            double totalAmountDeposit2 = totalAmountDeposit1 + totalAmountInterest2;

            double totalAmountInterest3 = totalAmountDeposit2 * interest;
            double totalAmountDeposit3 = totalAmountDeposit2 + totalAmountInterest3;

            Console.WriteLine($"{totalAmountDeposit1:f2}");

            Console.WriteLine($"{totalAmountDeposit2:f2}");

            Console.WriteLine($"{totalAmountDeposit3:f2}");

        }
    }
}
