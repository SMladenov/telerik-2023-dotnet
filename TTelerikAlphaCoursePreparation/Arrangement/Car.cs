using System;

namespace Arrangement
{
    internal class Car : Vehicle, IVehicle 
    {
        public Car(string model)
        {
            Make = model;
        }
        public void GetVehicleType()
        {
            Console.WriteLine("I am a car");
        }
    }
}
