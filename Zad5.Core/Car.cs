using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5.Core
{
    public class Car : IVehicle
    {
        public string LicensePlate { get; private set; }

        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
        }
    }
}
