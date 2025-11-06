using System;

namespace Left_Sum_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much numbers on the left and on the right: ");
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Numbers on the left: ");
                int leftNumbers = int.Parse(Console.ReadLine());
                leftSum = leftNumbers + leftSum;
            }

            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("Numbers on the right: ");
                int rightNumbers = int.Parse(Console.ReadLine());
                rightSum = rightNumbers + rightSum;
            }

            int sumTotal = leftSum + rightSum;

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {sumTotal}");
            }
            else
            {
                int difference = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
