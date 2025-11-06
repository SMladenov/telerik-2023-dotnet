using System;

namespace Phone_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double text = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            double freeMinutes = 60;
            double freeText = 20;

            double additionalText = text - freeText;
            double additionalMinutes = minutes - freeMinutes;

            double chargeMinutes = (minutes - freeMinutes) * 0.1d;
            double chargeText = (text - freeText) * 0.06d;

            double taxMinutes = chargeMinutes * 0.2d;
            double taxText = chargeText * 0.2d;
            double taxTotal = taxMinutes + taxText;

            double totalBill = chargeMinutes + chargeText + taxTotal + 12;
            double totalBillText = taxText + chargeText + 12;
            double totalBillMinutes = chargeMinutes + taxMinutes + 12;
            

            if (text > 20 && minutes > 60)
            {
                Console.WriteLine($"{additionalText + " additional messages for " + $"{chargeText:f2}" + " levas"}");
                Console.WriteLine($"{additionalMinutes + " additional minutes for " + $"{chargeMinutes:f2}" + " levas"}");
                Console.WriteLine($"{taxTotal:f2} additional taxes");
                Console.WriteLine($"{totalBill:f2} total bill");
            }
            else if (text > 20 && minutes <= 60)
            {
                Console.WriteLine($"{additionalText + " additional messages for " + $"{chargeText:f2}" + " levas"}");
                Console.WriteLine("0 additional minutes for 0.00 levas");
                Console.WriteLine($"{taxText:f2} additional taxes");
                Console.WriteLine($"{totalBillText:f2} total bill");
            }
            else if (text <= 20 && minutes > 60)
            {
                Console.WriteLine("0 additional messages for 0.00 levas");
                Console.WriteLine($"{additionalMinutes + " additional minutes for " + $"{chargeMinutes:f2}" + " levas"}");
                Console.WriteLine($"{taxMinutes:f2} additional taxes");
                Console.WriteLine($"{$"{totalBillMinutes:f2}" + " total bill"}");
            }
            else if (text <= 20 && minutes <= 60)
            {
                Console.WriteLine("0 additional messages for 0.00 levas");
                Console.WriteLine("0 additional minutes for 0.00 levas");
                Console.WriteLine("0.00 additional taxes");
                Console.WriteLine("12.00 total bill");
            }
            






        }
    }
}
