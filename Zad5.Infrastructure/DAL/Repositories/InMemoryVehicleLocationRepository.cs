using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core;
using Zad5.Core.Repositories;

namespace Zad5.Infrastructure.DAL.Repositories
{
    internal class InMemoryVehicleLocationRepository : IVehicleLocationRepository
    {
        private readonly List<VehicleLocation> _vehicleLocations;

        public InMemoryVehicleLocationRepository(List<VehicleLocation> vehicleLocations)
        {
            _vehicleLocations = vehicleLocations;
        }

        public IEnumerable<VehicleLocation> GetAll()
        {
            return _vehicleLocations.AsEnumerable();
        }

        public VehicleLocation? FindByVehicle(IVehicle vehicle)
        {
            return _vehicleLocations.FirstOrDefault(x => x.Vehicle == vehicle);
        }

        public void Add(VehicleLocation vehicleLocation)
        {
            _vehicleLocations.Add(vehicleLocation);
        }
    }
}
