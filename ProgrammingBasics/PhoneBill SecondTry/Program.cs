using System;

namespace PhoneBill_SecondTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            double planTax = 12;
            int messagesAboveThePlan = 0;
            int minutesAboveThePlan = 0;
            
            if(messages > 20)
            {
                messagesAboveThePlan = messages - 20;
            }

            if(minutes > 60)
            {
                minutesAboveThePlan = minutes - 60;
            }

            double messagesTaxesWithoutVat = messagesAboveThePlan * 0.06;
            double minutesTaxesWithoutVat = minutesAboveThePlan * 0.1;
            double taxesAboveThePlan = (messagesTaxesWithoutVat + minutesTaxesWithoutVat) * 0.20;
            double totalBill = messagesTaxesWithoutVat + minutesTaxesWithoutVat + taxesAboveThePlan + planTax;

            Console.WriteLine($"{messagesAboveThePlan} additional messages for {messagesTaxesWithoutVat:f2} levas");
            Console.WriteLine($"{minutesAboveThePlan} additional minutes for {minutesTaxesWithoutVat:f2} levas");
            Console.WriteLine($"{taxesAboveThePlan:f2} additional taxes");
            Console.WriteLine($"{totalBill:f2} total bill");


        }
    }
}
