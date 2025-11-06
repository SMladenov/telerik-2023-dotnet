using System;
using System.Collections.Generic;
using System.Text;

namespace Arrangement
{
    internal class Boat : Vehicle, IVehicle
    {
        public void GetVehicleType()
        {
            Console.WriteLine("I am a boat");
        }
    }
}
