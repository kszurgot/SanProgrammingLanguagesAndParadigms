using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core.Exceptions;

namespace Zad5.Core
{
    public class VehicleLocation
    {
        public IVehicle Vehicle { get; init; }
        public Street Street { get; private set; }
        public Intersection BeforeIntersection { get; private set; }

        public VehicleLocation(IVehicle vehicle, Street street, Intersection beforeIntersection)
        {
            CheckIntersection(street, beforeIntersection);

            Vehicle = vehicle;
            Street = street;
            BeforeIntersection = beforeIntersection;
        }

        public void UpdateLocation(Street street, Intersection beforeIntersection)
        {
            CheckIntersection(street, beforeIntersection);

            Street = street;
            BeforeIntersection = beforeIntersection;
        }

        private void CheckIntersection(Street street, Intersection beforeIntersection)
        {
            var hasIntersection = street.Intersections.Any(x => x.Equals(beforeIntersection));

            if (!hasIntersection)
            {
                throw new InvalidIntersectionForStreetException(beforeIntersection.Name, street.Name);
            }
        }
    }
}
