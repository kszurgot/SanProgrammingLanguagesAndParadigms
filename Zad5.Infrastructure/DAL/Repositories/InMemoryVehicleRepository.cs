using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core;
using Zad5.Core.Repositories;

namespace Zad5.Infrastructure.DAL.Repositories
{
    internal class InMemoryVehicleRepository : IVehicleRepository
    {
        private readonly List<IVehicle> _vehicle;
        public InMemoryVehicleRepository(List<IVehicle> vehicle)
        {
            _vehicle = vehicle;
        }

        public IEnumerable<IVehicle> GetAll()
        {
            return _vehicle.AsEnumerable();
        }
    }
}
