using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core;

namespace Zad5.Infrastructure
{
    internal class DatabaseInitializer
    {
        internal  List<District> Districts { get; init; }
        internal List<Street> Streets { get; init; }
        internal List<Intersection> Intersections { get; init; }
        internal List<IVehicle> Vehicles { get; init; }
        internal List<VehicleLocation> VehicleLocations { get; init; }

        internal DatabaseInitializer() 
        {
            Districts = new List<District>()
            {
                new District("Polesie"),
                new District("Śródmieście")
            };

            Streets = new List<Street>()
            {
                new Street("Wyszyńskiego", Districts[0]),
                new Street("Retkińska", Districts[0]),
                new Street("Armii Krajowej", Districts[0]),
                new Street("Sienkiewicza", Districts[1]),
                new Street("Juliana Tuwima", Districts[1]),
                new Street("Nawrot", Districts[1])
            };

            Intersection intersection;
            Intersections = new List<Intersection>();

            intersection = new Intersection(new HashSet<Street>()
            {
                Streets[0],
                Streets[1],
            });
            Intersections.Add(intersection);

            intersection = new Intersection(new HashSet<Street>()
            {
                Streets[0],
                Streets[2],
            });
            Intersections.Add(intersection);

            intersection = new Intersection(new HashSet<Street>()
            {
                Streets[3],
                Streets[4],
            });
            Intersections.Add(intersection);

            intersection = new Intersection(new HashSet<Street>()
            {
                Streets[3],
                Streets[5],
            });
            Intersections.Add(intersection);

            Vehicles = new List<IVehicle>();
            VehicleLocations = new List<VehicleLocation>();
            int carId = 1;

            foreach (var street in Streets)
            {
                foreach (var streetIntersection in street.Intersections)
                {
                    IVehicle vehicle = new Car(GenerateLicencePlate(carId));
                    Vehicles.Add(vehicle);

                    VehicleLocations.Add(new VehicleLocation(vehicle, street, streetIntersection));
                }
            }
        }

        static string GenerateLicencePlate(int carId)
        {
            return $"EL00{carId.ToString("00")}";
        }
    }
}
