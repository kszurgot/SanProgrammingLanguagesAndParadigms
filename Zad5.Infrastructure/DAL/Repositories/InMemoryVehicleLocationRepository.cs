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
        private List<VehicleLocation> vehicleLocations;

        public InMemoryVehicleLocationRepository(List<VehicleLocation> vehicleLocations)
        {
            this.vehicleLocations = vehicleLocations;
        }

        public IEnumerable<VehicleLocation> GetAll()
        {
            return vehicleLocations.AsEnumerable();
        }

        public void Add(VehicleLocation vehicleLocation)
        {
            vehicleLocations.Add(vehicleLocation);
        }
    }
}
