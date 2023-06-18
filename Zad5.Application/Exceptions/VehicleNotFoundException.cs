using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core.Shared.Exceptions;

namespace Zad5.Application.Exceptions
{
    internal class VehicleNotFoundException : CustomException
    { 
        public string LicensePlate { get; }

        public VehicleNotFoundException(string licensePlate)
            : base($"Pojazd z numerem rejestracyjny {licensePlate} nie został znaleziony.")
        {
            LicensePlate = licensePlate;
        }
    }
}
