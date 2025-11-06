using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter how many days you want to count: ");
            int days = int.Parse(Console.ReadLine());

            int threatedPatients = 0;
            int unthreatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                

                if (patients <= doctors)
                {
                    threatedPatients += patients;
                }
                if (unthreatedPatients > doctors && i % 3 == 0)
                {
                    doctors++;

                }
                if (patients > doctors)
                {
                    int patientsLeft = patients - doctors;
                    unthreatedPatients += patientsLeft;
                    threatedPatients += doctors;
                }

            }

            Console.WriteLine($"Threated Patients: {threatedPatients}");
            Console.WriteLine($"Unthreated Patients: {unthreatedPatients}");

        }
    }
}
