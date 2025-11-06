using System;

namespace Print_Company_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Company name:");
            string companyName = Console.ReadLine();

            Console.WriteLine("Company address:");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Fax number:");
            string faxNumber = Console.ReadLine();

            Console.WriteLine("Web site:");
            string webSite = Console.ReadLine();

            Console.WriteLine("Manager first name:");
            string managerFirstName = Console.ReadLine();

            Console.WriteLine("Manager last name:");
            string managerLastName = Console.ReadLine();

            Console.WriteLine("Manager age:");
            int managerAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Manager phone:");
            string managerPhone = Console.ReadLine();





            Console.WriteLine($"{companyName}");
            Console.WriteLine($"{"Address:" + companyAddress}");
            Console.WriteLine($"{"Tel." + phoneNumber}");
            Console.WriteLine("(no fax)");
            Console.WriteLine($"{"Web site:" + webSite}");
            Console.WriteLine($"{"Manager:" + managerFirstName + "" + managerLastName + "(age:" + managerAge + "," + "tel." + managerPhone + ")"}");

        }
    }
}
